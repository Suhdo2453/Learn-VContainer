public interface IDamageable
{
    void Damage(float value);
}

public interface IHeathable
{
    float Heath { get; set; }
}