using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bookshelf.Infra.Persistence.Entities.Course;
using Bookshelf.Infra.Persistence.Entities.UserLibrary;
using Microsoft.EntityFrameworkCore;

namespace Bookshelf.Infra.Persistence.Entities.UserLibraryCourse;

[Table("UserLibraryCourse")]
public class UserLibraryCourseE
{
    [Key]
    public long Id { get; set; }
    
    [ForeignKey("Course")]
    public long CourseId { get; set; }
    public CourseE Course { get; set; }
    
    [ForeignKey("UserLibrary")]
    public long UserLibraryId { get; set; }
    [DeleteBehavior(DeleteBehavior.NoAction)]
    public UserLibraryE UserLibrary { get; set; }
    
}