using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
[Table("Persion")]  
public class Persion
{
[Key]
public required string PersionId {get;set;}
public required string Fullname {get;set;}
public required string Address{get;set;}
// Employee class kế thừa từ Person


}
}