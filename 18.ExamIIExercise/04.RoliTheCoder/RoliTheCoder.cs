using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RoliTheCoder
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> Participants { get; set; }
    }

    public class RoliTheCoder
    {
        public static void Main()
        {
            var result = new List<Event>();
            var eventsById = new Dictionary<int, Event>();

            while (true)
            {
                string currentLine = Console.ReadLine();

                if (currentLine == "Time for Code")
                {
                    break;
                }

                var lineParts = currentLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var eventId = 0;

                if (!int.TryParse(lineParts[0], out eventId))
                {
                    continue;
                }

                string eventName = null;

                if (lineParts.Length > 1 && lineParts[1].StartsWith("#"))
                {
                    eventName = lineParts[1].Trim('#');
                }
                else
                {
                    continue;
                }

                var participansts = new List<string>();

                if (lineParts.Length > 2)
                {
                    participansts = lineParts.Skip(2).ToList();

                    if (!participansts.All(p => p.StartsWith("@")))
                    {
                        continue;
                    }
                }

                if (eventsById.ContainsKey(eventId))
                {
                    if (eventsById[eventId].Name == eventName)
                    {
                        var existingEvent = eventsById[eventId];

                        existingEvent.Participants.AddRange(participansts);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    var newEvent = new Event
                    {
                        Id = eventId,
                        Name = eventName,
                        Participants = participansts
                    };

                    result.Add(newEvent);
                    eventsById.Add(eventId, newEvent);
                }
            }

            var sortedEvents = result
                    .OrderByDescending(e => e.Participants.Distinct().Count())
                    .ThenBy(e => e.Name);

            foreach (var ev in sortedEvents)
            {
                var distinctParticipants = ev.Participants.Distinct().ToList();
                Console.WriteLine($"{ev.Name} - {distinctParticipants.Count}");
                foreach (var participant in distinctParticipants.OrderBy(p => p))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}