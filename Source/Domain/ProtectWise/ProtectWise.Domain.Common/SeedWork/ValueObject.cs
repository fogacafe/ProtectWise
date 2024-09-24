namespace ProtectWise.Domain.Common.SeedWork
{
    public abstract class ValueObject
    {
        // Lógica comum para comparação e criação de objetos imutáveis
        protected abstract IEnumerable<object> GetAtomicValues();

        public override bool Equals(object? obj)
        {
            if (obj is not ValueObject valueObject)
                return false;

            return GetAtomicValues().SequenceEqual(valueObject.GetAtomicValues());
        }

        public override int GetHashCode()
        {
            return GetAtomicValues()
                .Aggregate(1, (current, obj) => current * 31 + (obj?.GetHashCode() ?? 0));
        }
    }
}
