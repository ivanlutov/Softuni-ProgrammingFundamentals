using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.NoteStatistics
{
    public class NoteStatistics
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToList();

            List<string> notes = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            List<double> frequencies = new List<double> { 261.63, 277.18, 293.66, 311.13, 329.63,
                349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };

            List<string> resultNotes = new List<string>();

            foreach (var frequency in input)
            {
                var note = notes[frequencies.IndexOf(frequency)];

                resultNotes.Add(note);
            }

            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();

            for (int i = 0; i < resultNotes.Count; i++)
            {
                if (resultNotes[i].Contains("#"))
                {
                    sharps.Add(resultNotes[i]);
                }
                else
                {
                    naturals.Add(resultNotes[i]);
                }
            }

            List<double> sumNaturals = new List<double>();

            foreach (var note in naturals)
            {
                var sum = frequencies[notes.IndexOf(note)];

                sumNaturals.Add(sum);
            }

            List<double> sumSharps = new List<double>();

            foreach (var note in sharps)
            {
                var sum = frequencies[notes.IndexOf(note)];

                sumSharps.Add(sum);
            }

            Console.WriteLine($"Notes: {string.Join(" ", resultNotes)}");
            Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");
            Console.WriteLine($"Naturals sum: {sumNaturals.Sum()}");
            Console.WriteLine($"Sharps sum: {sumSharps.Sum()}");
        }
    }
}