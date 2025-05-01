using System.IO;
using System.Collections.Generic;

namespace TpSouls
{
    internal class TPoint
    {
        public string name;

        public float posX;
        public float posY;
        public float posZ;

        public TPoint(string name, float posX, float posY, float posZ)
        {
            this.name = name;
            this.posX = posX;
            this.posY = posY;
            this.posZ = posZ;
        }

        public static void Save(string path, List<TPoint> tPoints)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            using (BinaryWriter binWriter = new BinaryWriter(fs))
            {
                binWriter.Write(tPoints.Count);

                for (int i = 0; i < tPoints.Count; i++)
                {
                    binWriter.Write(tPoints[i].name);
                    binWriter.Write(tPoints[i].posX);
                    binWriter.Write(tPoints[i].posY);
                    binWriter.Write(tPoints[i].posZ);
                }
            }
        }

        public static List<TPoint> Load(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (BinaryReader binReader = new BinaryReader(fs))
            {
                int count = binReader.ReadInt32();

                List<TPoint> tPoints = new List<TPoint>(count);

                for (int i = 0; i < count; i++)
                {
                    string name = binReader.ReadString();
                    float posX = binReader.ReadSingle();
                    float posY = binReader.ReadSingle();
                    float posZ = binReader.ReadSingle();

                    tPoints.Add(new TPoint(name, posX, posY, posZ));
                }

                return tPoints;
            }
        }
    }
}
