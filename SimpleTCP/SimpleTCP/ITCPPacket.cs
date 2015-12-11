namespace SimpleTCP
{
    public interface ITCPPacket<T>
    {
        byte[] bytes { get; set; }

        object ByteArrayToObject(byte[] bytes);
        byte[] ObjectToByteArray(T data);
    }
}