using System;
using System.Linq;
using EntityModel;
using Microsoft.Extensions.Logging;

namespace Helper
{
    public class TestHelper
    {
        private readonly BlogDbContext _context;
        private readonly ILogger<TestHelper> _logger;
        public TestHelper(BlogDbContext blogDbContext, ILogger<TestHelper> logger)
        {
            _context = blogDbContext;
            _logger = logger;
        }

        public void RunTest()
        {
            _context.Database.EnsureCreated();// 是新的EF核心方法,可确保上下文的数据库存在.如果存在,则不采取任何措施.如果它不存在,则创建数据库及其所有模式,并确保它与此上下文的模型兼容.
            var s = _context.Users.ToList();
            _logger.LogInformation(s.Count().ToString());
        }
    }
}
