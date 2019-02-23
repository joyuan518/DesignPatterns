namespace DesignPatterns.Flyweight
{
    public static class Client
    {
        public static void Run()
        {
            //The intention of Flyweight pattern is that we can share the intrinsic states of a type of objects and 
            //they can still have their own extrinsic states for each of them. This will be useful when we wanted to 
            //create a lot of objects in one type and we want to share the common states of them so that we can 
            //reduce the amount of memory that is needed to create so many objects. 
            var char1 = CharactorDataFactory.GetCharactorData('A', 2, 3);
            var char2 = CharactorDataFactory.GetCharactorData('B', 2, 1);
            var char3 = CharactorDataFactory.GetCharactorData('B', 3, 1);
            var char4 = CharactorDataFactory.GetCharactorData('A', 1, 1);

            char1.Draw();
            char2.Draw();
            char3.Draw();
            char4.Draw();
        }
    }
}