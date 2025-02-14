public interface IMission
{
    void Execute(AiController controller);  // Görevi yerine getirme
    string MissionName { get; }  // Görev adý bilgisi
}
