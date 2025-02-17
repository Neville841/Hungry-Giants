public interface IMission
{
    AiController aiController { get; set; }
    void Execute(AiController controller); // Görevi yerine getirme
    string MissionName { get; }  // Görev adý bilgisi
}
