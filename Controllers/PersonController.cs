using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using MvcMovie.Models;
using MvcMovie.Data;

namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Person/Upload
        public IActionResult Upload()
        {
            return View();
        }

        // POST: Person/Upload
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
                if (!Directory.Exists(uploadsFolder))
                    Directory.CreateDirectory(uploadsFolder);

                var filePath = Path.Combine(uploadsFolder, Path.GetFileName(file.FileName));

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                // Đọc Excel
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;

                    var people = new List<Person>();

                    for (int row = 2; row <= rowCount; row++)
                    {
                        try
                        {
                            var person = new Person
                            {
                                FullName = worksheet.Cells[row, 1].Text,

                                Email = worksheet.Cells[row, 3].Text
                            };
                            people.Add(person);
                        }
                        catch
                        {
                            ViewBag.Message = $"Lỗi dữ liệu ở dòng {row}";
                            return View();
                        }
                    }

                    _context.People.AddRange(people);
                    await _context.SaveChangesAsync();
                }

                ViewBag.Message = "Upload và import thành công!";
            }
            else
            {
                ViewBag.Message = "Vui lòng chọn file!";
            }

            return View();
        }
    }
}
