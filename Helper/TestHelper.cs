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
           var s = _context.Users.ToList();
            _logger.LogInformation(s.Count().ToString());
        }
    }
}
