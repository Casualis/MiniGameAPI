namespace MiniGameAPIBase.Model.Enums
{
    /// <summary>
    /// Тип свойства. 
    /// </summary>
    [Flags]
    public enum PropertyType
    {
        None = 0,
        // позиция
        Position   = 0x00000001, // 1
        // направоление
        Direction  = 0x00000010, // 2
        // запас патронов
        AmmoSupply = 0x00000100  // 4
    }
}
