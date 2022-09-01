using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicDI.Models.Database
{
  public class DIEntities : DbContext
  {
    private static string _connString;

    internal static string ConnString
    {
      get { return !string.IsNullOrWhiteSpace(_connString) ? _connString : "***"; }
      set { _connString = value; }
    }

    public DIEntities() : base(ConnString) { }

    public virtual DbSet<ClassRoom> ClassRooms { get; set; }
    public virtual DbSet<Student> Students { get; set; }
  }

  public class ClassRoom
  {
    [Key]
    public int ClassRoomId { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
  }

  public class Student
  {
    [Key]
    public int StudentId { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
    [ForeignKey("ClassRoom")]
    public int? ClassRoomId { get; set; }
    public ClassRoom ClassRoom { get; set; }
  }
}
