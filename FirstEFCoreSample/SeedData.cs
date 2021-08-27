using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityModel;

namespace FirstEFCoreSample
{
    /// <summary>
    /// 初始化数据库类
    /// </summary>
    public class SeedData
    {
        private readonly BlogDbContext _context;
        public SeedData(BlogDbContext blogDbContext)
        {
            _context = blogDbContext;
        }

        public void InitializeData()
        {
            _context.Database.EnsureCreated();// 是新的EF核心方法,可确保上下文的数据库存在.如果存在,则不采取任何措施.如果它不存在,则创建数据库及其所有模式,并确保它与此上下文的模型兼容.

            if (!_context.Users.Any())
            {
                _context.Users.Add(new User() { Id = 1, UserName = "admin" });
            }
            _context.SaveChanges();
        }
    }
}
