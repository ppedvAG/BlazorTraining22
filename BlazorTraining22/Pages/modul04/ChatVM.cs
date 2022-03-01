namespace BlazorTraining22.Pages.modul04
{
    public class ChatVM
    {
        public Action onAdd;
        public List<string> ChatListe { get; set; }=new List<string>(); 
        public void Add(string msg)
        {
            ChatListe.Add(msg);
            onAdd?.Invoke();
        }

    }
}
