using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteStatistics
{
    class NoteStatistics
    {
        static void Main(string[] args)
        {
            var inputNotes = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            var inputFrequency = new List<double> { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };

            var dictionary = new Dictionary<double, string>();
            for (int i = 0; i < inputNotes.Count; i++)
            {
                var currentNote = inputNotes[i];
                var currentFrequency = inputFrequency[i];

                dictionary.Add(currentFrequency, currentNote);
            }

            var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            var notes = new List<string>();
            var naturals = new List<string>();
            var sharps = new List<string>();
            foreach (var frequencyEntry in inputLine)
            {
                if (dictionary.ContainsKey(frequencyEntry))
                {
                    notes.Add(dictionary[frequencyEntry]);
                }
            }

            foreach (var note in notes)
            {
                if (!note.EndsWith("#"))
                {
                    naturals.Add(note);
                }
                else
                {
                    sharps.Add(note);
                }
            }


            var naturalsSum = 0.0;
            foreach (var natural in naturals)
            {
                foreach (var pair in dictionary)
                {
                    if(pair.Value.Equals(natural))
                    {
                        naturalsSum += pair.Key;
                    }
                }
            }

            var sharpsSum = 0.0;
            foreach (var sharp in sharps)
            {
                foreach (var pair in dictionary)
                {
                    if (pair.Value.Equals(sharp))
                    {
                        sharpsSum += pair.Key;
                    }
                }
            }

            Console.WriteLine("Notes: {0}", string.Join(" ", notes));
            Console.WriteLine("Naturals: {0}", string.Join(", ", naturals));
            Console.WriteLine("Sharps: {0}", string.Join(", ", sharps));

            if(naturalsSum > 0)
            {
                Console.WriteLine("Naturals sum: {0:f2}", naturalsSum);
            }
            else
            {
                Console.WriteLine("Naturals sum: {0:f0}", naturalsSum);
            }

            if (sharpsSum > 0)
            {
                Console.WriteLine("Sharps sum: {0:f2}", sharpsSum);
            }
            else
            {
                Console.WriteLine("Sharps sum: {0:f0}", sharpsSum);
            }
           



            //Play frequency

            //foreach (var freq in inputFrequency)
            //{
            //    Console.Beep((int)freq, 2000);
            //}

            //Console.WriteLine();
        }
    }
}
