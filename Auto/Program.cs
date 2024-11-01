using Auto.Models;

namespace Auto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task

            /*
             Vehicle adlı abstrakt sinif yaradın. Bu sinif hər bir nəqliyyat vasitəsi üçün ümumi olan Brand, Model, MaxSpeed propertyleri və Drive() metodunu özündə cəmləşdirməlidir.

             Bu sinifdən irsi alan Car, Motorcycle və Train adlı fərqli siniflər yaradın. Hər bir sinif özünəməxsus xüsusiyyətləri əlavə etməli və Drive() metodunu fərqli şəkildə həyata keçirməlidir.

             Car sinfi üçün FuelType, Motorcycle üçün RaceType, Train üçün CarriageCount kimi əlavə xüsusiyyətlər daxil edin.

             MaxSpeed və CarriageCount kimi sahələri qorumaq üçün get və set metodları ilə kapsula edin. MaxSpeed yalnız müsbət ədədləri qəbul etməli, CarriageCount isə minimum 1 olmalıdır.

             Brand və Model xüsusiyyətləri yalnız sinif daxilindən dəyişdirilə biləcək şəkildə yazılmalıdır (readonly kimi).

             Nəqliyyat vasitələrinin fərqli səslər çıxara bilməsi üçün ISound adlı bir interfeys yaradın. Bu interfeysdə MakeSound() adlı metod olsun.

             Car, Motorcycle, və Train sinifləri bu interfeysdən istifadə etməli və hər birində fərqli səs çıxarmalıdır (məsələn, Car üçün “Bip-bip!”, Train üçün “Tuf-tuf!”).

             Main metodunda müxtəlif nəqliyyat vasitələrindən obyektlər yaradın və onların Drive(), MakeSound() metodlarını çağırın.
             */
            #endregion

            Car car = new Car("Bmw", "M3", "Diesel");
            car.MakeSound();

            Train train = new Train("Test", "Test", 10);
            train.MakeSound();
        }
    }
}
