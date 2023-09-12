using System;
using System.Collections.Generic;

namespace PokemonTypes
{
    class PokemonType
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Día:{Environment.NewLine}");
            PokemonType[] tipos1 = new PokemonType[]
            {
                new PokemonType() { Name = "normal" },
                new PokemonType() { Name = "fuego" },
                new PokemonType() { Name = "agua" },
                new PokemonType() { Name = "planta" },
                new PokemonType() { Name = "bicho" },
                new PokemonType() { Name = "siniestro" },
                new PokemonType() { Name = "dragon" },
                new PokemonType() { Name = "eléctrico" },
                new PokemonType() { Name = "hada" },
                new PokemonType() { Name = "lucha" },
                new PokemonType() { Name = "fantasma" },
                new PokemonType() { Name = "psíquico" },
            };

            Console.WriteLine($"Día:{Environment.NewLine}");
            PokemonType[] tipos2 = new PokemonType[]
            {
                new PokemonType() { Name = "tierra" },
                new PokemonType() { Name = "lucha" },
                new PokemonType() { Name = "hielo" },
                new PokemonType() { Name = "hada" },
                new PokemonType() { Name = "veneno" },
                new PokemonType() { Name = "fantasma" },
                new PokemonType() { Name = "acero" },
                new PokemonType() { Name = "fuego" },
                new PokemonType() { Name = "psíquico" },
                new PokemonType() { Name = "roca" },
                new PokemonType() { Name = "lucha" },
                new PokemonType() { Name = "agua" },
                new PokemonType() { Name = "tierra" },
                new PokemonType() { Name = "lucha" },
                new PokemonType() { Name = "hielo" },
                new PokemonType() { Name = "hada" },
                new PokemonType() { Name = "veneno" },
                new PokemonType() { Name = "fantasma" },
                new PokemonType() { Name = "acero" },
                new PokemonType() { Name = "fuego" },
                new PokemonType() { Name = "psíquico" },
                new PokemonType() { Name = "roca" },
                new PokemonType() { Name = "lucha" },
                new PokemonType() { Name = "agua" },
            };

            foreach (PokemonType type in tipos1)
                {
                Console.WriteLine(type.Name);
            }

            Console.Read();
        }
    }
}
