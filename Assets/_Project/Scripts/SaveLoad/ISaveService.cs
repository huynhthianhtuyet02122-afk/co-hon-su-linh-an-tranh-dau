namespace CoHonSu.Foundation.SaveLoad
{
    public interface ISaveService
    {
        bool TryLoad(out SaveGameData saveData);
        void Save(SaveGameData saveData);
        void Delete();
    }
}
