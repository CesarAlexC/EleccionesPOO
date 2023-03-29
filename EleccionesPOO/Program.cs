using EleccionesPOO;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dame el número de candidatos:");
        int numCandidatos = int.Parse(Console.ReadLine());

        Console.WriteLine("Dame el número de votantes:");
        int numVotantes = int.Parse(Console.ReadLine());

        List<Votante> votantes = new List<Votante>();

        for (int i = 0; i < numVotantes; i++)
        {
            Console.WriteLine($"¿Por cuál candidato va a votar el votante {i + 1}?");
            int voto = int.Parse(Console.ReadLine());
            Votante votante = new Votante(voto);
            votantes.Add(votante);
        }

        List<Candidato> candidatos = new List<Candidato>();

        for (int i = 1; i <= numCandidatos; i++)
        {
            int votos = votantes.Count(v => v.Voto == i);
            Candidato candidato = new Candidato(i, votos);
            candidatos.Add(candidato);
            Console.WriteLine($"Votos para el candidato {i}: {votos}");
        }

        Console.ReadLine();
    }
}
