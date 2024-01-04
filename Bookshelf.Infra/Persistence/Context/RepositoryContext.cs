using Bookshelf.Infra.Persistence.Entities.Author;
using Bookshelf.Infra.Persistence.Entities.Book;
using Bookshelf.Infra.Persistence.Entities.BookAuthor;
using Bookshelf.Infra.Persistence.Entities.BookCategory;
using Bookshelf.Infra.Persistence.Entities.BookCopy;
using Bookshelf.Infra.Persistence.Entities.Borrowing;
using Bookshelf.Infra.Persistence.Entities.Category;
using Bookshelf.Infra.Persistence.Entities.Course;
using Bookshelf.Infra.Persistence.Entities.Institution;
using Bookshelf.Infra.Persistence.Entities.LibPermission;
using Bookshelf.Infra.Persistence.Entities.Library;
using Bookshelf.Infra.Persistence.Entities.LibraryCourse;
using Bookshelf.Infra.Persistence.Entities.Password;
using Bookshelf.Infra.Persistence.Entities.Penality;
using Bookshelf.Infra.Persistence.Entities.PenalityType;
using Bookshelf.Infra.Persistence.Entities.Publisher;
using Bookshelf.Infra.Persistence.Entities.SysPermission;
using Bookshelf.Infra.Persistence.Entities.UserAccount;
using Bookshelf.Infra.Persistence.Entities.UserContact;
using Bookshelf.Infra.Persistence.Entities.UserContactType;
using Bookshelf.Infra.Persistence.Entities.UserLibrary;
using Bookshelf.Infra.Persistence.Entities.UserLibraryCourse;
using Bookshelf.Infra.Persistence.Entities.UserLibraryProfile;
using Bookshelf.Infra.Persistence.Entities.UserLibraryProfileLibPermission;
using Bookshelf.Infra.Persistence.Entities.UserProfile;
using Bookshelf.Infra.Persistence.Entities.UserProfileSysPermission;
using Microsoft.EntityFrameworkCore;

namespace Bookshelf.Infra.Persistence.Context;

public class RepositoryContext: DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
    {
    }

    public DbSet<BookE> Books { get; set; }
    public DbSet<AuthorE> Author { get; set; }
    public DbSet<BookAuthorE> BookAuthor { get; set; }
    public DbSet<BookCategoryE> BookCategory { get; set; }
    public DbSet<BookCopyE> BookCopy { get; set; }
    public DbSet<BorrowingE> Borrowing { get; set; }
    public DbSet<CategoryE> Category { get; set; }
    public DbSet<CourseE> Course { get; set; }
    public DbSet<InstitutionE> Institution { get; set; }
    public DbSet<LibPermissionE> LibPermission { get; set; }
    public DbSet<LibraryE> Library { get; set; }
    public DbSet<LibraryCourseE> LibraryCourse { get; set; }
    public DbSet<PasswordE> Password { get; set; }
    public DbSet<PenalityE> Penality { get; set; }
    public DbSet<PenalityTypeE> PenalityType { get; set; }
    public DbSet<PublisherE> Publisher { get; set; }
    public DbSet<SysPermissionE> SysPermission { get; set; }
    public DbSet<UserAccountE> UserAccount { get; set; }
    public DbSet<UserContactE> UserContact { get; set; }
    public DbSet<UserContactTypeE> UserContactType { get; set; }
    public DbSet<UserLibraryE> UserLibrary { get; set; }
    public DbSet<UserLibraryCourseE> UserLibraryCourse { get; set; }
    public DbSet<UserLibraryProfileE> UserLibraryProfile { get; set; }
    public DbSet<UserLibraryProfileLibPermissionE> UserLibraryProfileLibPermission { get; set; }
    public DbSet<UserProfileE> UserProfile { get; set; }
    public DbSet<UserProfileSysPermissionE> UserProfileSysPermission { get; set; }
}