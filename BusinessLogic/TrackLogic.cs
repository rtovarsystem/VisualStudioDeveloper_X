using DataAccess;
using System.Linq;

namespace BusinessLogic
{
    public class TrackLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public TrackLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public string GetComposer(int id)
        {
            var list = _unitOfWork.Tracks.GetAll().ToList();

            var record = list.First(x => x.TrackId == id);

            return record.Composer;
        }
    }
}
