namespace Laboratorium_3___App.Models
{
    public interface IReservationService
    {
        int Add(Reservation reservation);
        void Delete(int id);
        void Update(Reservation reservation);
        List<Reservation> FindAll();
        Reservation? FindById(int id);
    }
}
