using Newtonsoft.Json;

namespace Template
{

    //ICloneable interface provide a default clone method, support Reset method of controller
    public interface ICloneable<T>
    {
        public T CloneSelf()
        {
            var serialized = JsonConvert.SerializeObject(this, Formatting.Indented);
            return JsonConvert.DeserializeObject<T>(serialized);
        }
    }
}