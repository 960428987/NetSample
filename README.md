# NetSample

## 集合自己开发过程中的一些示例代码，用以笔记和学习

## EFCore 笔记

### dbcontext使用
用依赖注入的方式使用dbcontext时，有时有的类不能使用注入的方式，但需要用到dbcontext时，可以用下面的方式获取到dbcontext和options，这里需要引Microsoft.Extensions.DependencyInjection;

     using (var context = HttpContext.RequestServices.GetService<BlogDbContext>())
            {
                var userList = context2.Users.ToList();
            }
            var options = HttpContext.RequestServices.GetService<DbContextOptions<BlogDbContext>>();//获取dbcontext的选项

context就可以用来操作数据库了，

### 服务注入
     public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BlogDbContext>(options=>options.UseMySql(Configuration.GetConnectionString("blog_db"),ServerVersion.Parse("5.7.31-mysql")));
            services.AddControllersWithViews();
            TestService(services);
        }
        public void TestService(IServiceCollection services)
        {
            var service = services.BuildServiceProvider();//将服务集合build一下，然后注入到TestHelper，
            var instance = ActivatorUtilities.CreateInstance<TestHelper>(service);//通过ActivatorUtilities相当于反射获取到TestHelper类
            instance.RunTest();
        }

TestClass

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

### 并发冲突与令牌

并发分悲观并发和乐观并发。

悲观并发：比如有两个用户A,B，同时登录系统修改一个文档，如果A先进入修改，则系统会把该文档 锁住，B就没办法打开了，只有等A修改完，完全退出的时候B才能进入修改。

乐观并发：同上面的例子，A,B两个用户同时登录，如果A先进入修改紧跟着B也进入了。A修改文档的 同时B也在修改。如果在A保存之后B再保存他的修改，此时系统检测到数据库中文档记录与B刚进入时 不一致，B保存时会抛出异常，修改失败。

Entity Framework Core 不支持悲观并发，只支持乐观并发

![](http://bpic.588ku.com/element_origin_min_pic/16/10/29/2ac8e99273bc079e40a8dc079ca11b1f.jpg)

![](https://raw.githubusercontent.com/960428987/Images/master/resource/1.png)

![](https://raw.githubusercontent.com/960428987/Images/master/resource/2.jpg)

## Links and Images

This is an [example inline link](https://www.actiprosoftware.com "Actipro Software") with tooltip text specified.
[This link](https://www.actiprosoftware.com) has no tooltip text specified.

URLs and e-mail addresses can be turned into links by enclosing them in angle braces:

- <https://www.actiprosoftware.com>  
- <support@microsoft.com>

[This link](#markdown-document) links to the first heading in this document via custom ID.

## Images

This is an example of an image:

![Image](https://www.microsoft.com/favicon.ico)

This is an example of an image with a link:

[![Image](https://www.google.com/favicon.ico)](https://www.google.com)

## Blockquotes

Markdown said:

> This is the first level of quoting.
>
> > This is a nested blockquote.
>
> Back to the first level.

## Lists

Unordered list using minus signs (-):

- Step 1
- Step 2
- Step 3
  - Step 3a
  - Step 3b
  - Step 3c

Unordered list using plus signs (+):

+ Step 1
+ Step 2
+ Step 3
  + Step 3a
  + Step 3b
  + Step 3c

Unordered list using asterisks (*):

* Step 1
* Step 2
* Step 3
  * Step 3a
  * Step 3b
  * Step 3c

Ordered list:

1. Step 1
1. Step 2
1. Step 3
    1. Step 3a
    1. Step 3b
    1. Step 3c

Nested (unordered within ordered) list:

1. Step 1
1. Step 2
1. Step 3
    - Step 3a
    - Step 3b
    - Step 3c

Definition list:

Term #1
: This is the definition of term #1.

Term #2
: This is the definition of term #2.

## Code Blocks

Inline `code` can be delimited with characters.

This code block is fenced with three backticks and has its language specified:

```javascript
var oldUnload = window.onbeforeunload;
window.onbeforeunload = function() {
    saveCoverage();
    if (oldUnload) {
        return oldUnload.apply(this, arguments);
    }
};
```

This code block is fenced with three tildes and has its language specified:

~~~ruby
require 'redcarpet'
markdown = Redcarpet.new("Hello World!")
puts markdown.to_html
~~~

This code block is created by indenting the code, but no language can be specified:

    var foo = 1;

## Tables

| Fruit  | Color  |
|--------|--------|
| Apples | Red    |
| Grapes | Purple |
| Lemons | Yellow |

## Horizontal Rules

Horizontal rules are formed by placing three or more hyphens, asterisks, or underscores on a line by themselves.

---

***

___

## HTML Tags

<strong>HTML tags</strong> can optionally be used in <em>Markdown</em>.

## Special Characters

Unescaped:
\ ` * _ { } [ ] ( ) # + - . !

Backslash-Escaped:
\\ \` \* \_ \{ \} \[ \] \( \) \# \+ \- \. \!
