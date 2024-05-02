using GitGate4.Dice;
using GitGate4.Factory;
using GitGate4.GameControl;
using GitGate4.Logger;
using GitGate4.Weapon;
using Microsoft.Extensions.DependencyInjection;

namespace GitGate4
{
    internal class StartupConfig
    {
        public ServiceCollection configureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<IWeapon, Dagger>();
            services.AddScoped<IDice, CustomDice>();
            services.AddScoped<IConsoleLogger, ConsoleLogger>();
            services.AddScoped<IWeaponCreator, WeaponCreator>();
            services.AddScoped<IEnemyCreator, EnemyCreator>();
            services.AddScoped<ICharacterCreator, CharacterCreator>();
            //TODO: Er MOET altijd een singleton zijn, ook in de eindapplicatie.
            services.AddSingleton<IGame, Game>();
            return services;
        }

    }
}
