using Microsoft.AspNetCore.Identity;

namespace McvSoporte
{
    public class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider services)
        {
            // Comprobar y crear los roles predeterminados
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            await CrearRolesAsync(roleManager);
            // Comprobar y crear el administrador predeterminado
            var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
            await CrearAdminAsync(userManager);
        }
        private static async Task CrearRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            // Si no existe, se crea el rol predeterminado "Administrador"
            string nombreRol = "Administrador";
            var yaExiste = await roleManager.RoleExistsAsync(nombreRol);
            if (!yaExiste)
                await roleManager.CreateAsync(new IdentityRole(nombreRol));
            // Si no existe, se crea el rol predeterminado "Usuario"
            nombreRol = "Usuario";
            yaExiste = await roleManager.RoleExistsAsync(nombreRol);
            if (!yaExiste)
                await roleManager.CreateAsync(new IdentityRole(nombreRol));
        }
        private static async Task CrearAdminAsync(UserManager<IdentityUser> userManager)
        {
            // Comprobar si existe el administrador predetermindado
            var testAdmin = userManager.Users
            .Where(x => x.UserName == "admin@empresa.com")
            .SingleOrDefault();
            if (testAdmin != null) return;
            testAdmin = new IdentityUser
            {
                UserName = "admin@empresa.com",
                Email = "admin@empresa.com"
            };
            string admPasswd = "Admin-123";
            // Si no existe, se crea el administrador predeterminado "admin@empresa.com"
            IdentityResult userResult;
            userResult = await userManager.CreateAsync(testAdmin, admPasswd);

            // Se agrega el rol "Administrador" al administrador predeterminado
            if (userResult.Succeeded)
            {
                await userManager.AddToRoleAsync(testAdmin, "Administrador");
            }
        }
    }
}
