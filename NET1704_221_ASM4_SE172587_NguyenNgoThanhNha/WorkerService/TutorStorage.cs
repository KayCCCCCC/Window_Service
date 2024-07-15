using System.Collections.Concurrent;

namespace WorkerService
{
    public class TutorStorage
    {
        private ConcurrentBag<Tutor> _tutors = new ConcurrentBag<Tutor>();

        public void InsertTutors(List<Tutor> tutors)
        {
            tutors.ForEach(tutor => _tutors.Add(tutor));
        }

        public IEnumerable<Tutor> GetTutors()
        {
            return _tutors;
        }

        public void RemoveDeletedTutors()
        {
            var remainingTutors = _tutors.Where(t => t.IsDeleted == false);
            _tutors = new ConcurrentBag<Tutor>(remainingTutors);
        }
    }
}
