public interface IFoldable
{
    bool Folded { get; }
    void Fold();
    void Unfold();
}