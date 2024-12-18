namespace ChurchFinanceSystem
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configuração do banco de dados com Entity Framework
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );

            // Adicionando AutoMapper para mapeamento de objetos
            services.AddAutoMapper(typeof(Startup));

            // Injeção de dependência para os repositórios
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICongregationRepository, CongregationRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IInvoiceCategoryRepository, InvoiceCategoryRepository>();

            // Injeção de dependência para os serviços
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICongregationService, CongregationService>();
            services.AddScoped<IInvoiceService, InvoiceService>();
            services.AddScoped<IInvoiceCategoryService, InvoiceCategoryService>();

            // Adicionando controllers e o MVC
            services.AddControllers();

            // Configuração do CORS (caso seja necessário habilitar para chamadas de origens diferentes)
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader());
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                // Exibe informações detalhadas de erros no desenvolvimento
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // Para ambientes de produção, ativa a paginação de erros genéricos
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            // Configuração do CORS
            app.UseCors("AllowAll");

            // Redireciona HTTP para HTTPS
            app.UseHttpsRedirection();

            // Ativa o roteamento de requisições
            app.UseRouting();

            // Ativa a autenticação (caso necessário, como JWT ou cookie-based)
            app.UseAuthentication(); // Descomente se usar autenticação
            app.UseAuthorization();  // Descomente se usar autorização

            // Mapeia as rotas para os controladores
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // Mapeia os controllers da API
            });
        }
    }
}
