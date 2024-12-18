namespace MVC_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddScoped<AuthorService>();
            builder.Services.AddScoped<AuthorModel>();
            builder.Services.AddScoped<BookService>();
            builder.Services.AddScoped<BooksModel>();

            var app = builder.Build();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                _ = endpoints.MapControllers();
            });

            app.Run();
        }
    }
}
