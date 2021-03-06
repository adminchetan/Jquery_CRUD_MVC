//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jquery_CRUD_MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GitExamplesEntities : DbContext
    {
        public GitExamplesEntities()
            : base("name=GitExamplesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<UserMaster> UserMasters { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
    
        public virtual ObjectResult<UserMaster> sp_GetAllEmployee()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserMaster>("sp_GetAllEmployee");
        }
    
        public virtual ObjectResult<UserMaster> sp_GetAllEmployee(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserMaster>("sp_GetAllEmployee", mergeOption);
        }
    
        public virtual ObjectResult<UserMaster> sp_AddTomain(string name, string mobile)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("mobile", mobile) :
                new ObjectParameter("mobile", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserMaster>("sp_AddTomain", nameParameter, mobileParameter);
        }
    
        public virtual ObjectResult<UserMaster> sp_AddTomain(string name, string mobile, MergeOption mergeOption)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("mobile", mobile) :
                new ObjectParameter("mobile", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserMaster>("sp_AddTomain", mergeOption, nameParameter, mobileParameter);
        }
    
        public virtual int sp_AlterDeactiveEmployee(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AlterDeactiveEmployee", idParameter);
        }
    }
}
