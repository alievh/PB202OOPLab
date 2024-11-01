using Zoo.Models;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task
            /*
             Animal adlı abstrakt bir sinif yaradın. Bu sinifdə hər bir heyvan üçün ümumi olan Name, Age propertylerini və Eat() metodunu müəyyən edin.

             Müxtəlif heyvan növlərini təmsil edən siniflər (Leon, Elephant, Horse və s.) yaradın və bunları Heyvan sinfindən irs alaraq yaradın.
             
             Hər heyvan növünün özünə xas olan xüsusiyyətlərini və Eat() metodunu fərqli şəkildə həyata keçirin.
             
             Hər heyvanın Age məlumatlarını yalnız get və set metodları vasitəsilə əldə edilə bilən şəkildə kapsula edin.
             
             Age məlumatı üçün yalnız müsbət ədədlərin qəbul olunmasını təmin edən məntiq yazın.
             
             Heyvanlar üçün bir MakeSound() metodu yaradın. Bu metod fərqli heyvan növlərində fərqli səslər çıxarmalıdır. 
             
             Main metodunda müxtəlif heyvan siniflərindən obyektlər yaradın və onların Eat() və MakeSound() metodlarını çağıraraq nəticələrini yoxlayın.
             */
            #endregion

            Leon leon = new Leon();
            leon.Name = "Salam";
            leon.Age = 10;
            leon.MakeSound();
            leon.Eat();

            Elephant elephant = new Elephant();
            elephant.Name = "Firdovsi";
            elephant.Age = 20;
            elephant.MakeSound();
            elephant.Eat();
        }
    }
}
