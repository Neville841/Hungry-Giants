public interface IMission
{
    void Execute(AiController controller);  // G�revi yerine getirme
    string MissionName { get; }  // G�rev ad� bilgisi
}
