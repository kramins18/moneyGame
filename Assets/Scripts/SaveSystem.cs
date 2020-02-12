using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void saveGame(GameData gd)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        // string path = Application.persistentDataPath + "/player.fun";
        string path = Application.persistentDataPath + @"\s.txt";
        FileStream stream = new FileStream(path, FileMode.Create);
        formatter.Serialize(stream, gd);
        stream.Close();
    }
    public static GameData  loadGame()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + @"\s.txt";
        FileStream stream = new FileStream(path, FileMode.Open);

        GameData gd = formatter.Deserialize(stream) as GameData;
        stream.Close();
        return gd;
        
    }

  /*  public static void saveStore(StoreController[] sc)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        // string path = Application.persistentDataPath + "/player.fun";
        string path = Application.persistentDataPath + @"\store.txt";
        FileStream stream = new FileStream(path, FileMode.Create);
        StoreData[] sd = new StoreData[sc.Length];
        for (int i = 0; i < sc.Length; i++)
        {
            sd[i] = new StoreData(sc[i]);
        }


        
        formatter.Serialize(stream, sd);
        

        stream.Close();
    }
    public static StoreData[] loadStoreData()
    {

        BinaryFormatter formatter = new BinaryFormatter();
        // string path = Application.persistentDataPath + "/player.fun";
        string path = Application.persistentDataPath + @"\store.txt";
        FileStream stream = new FileStream(path, FileMode.Open);
        StoreData[] sd = formatter.Deserialize(stream) as StoreData[];
       
    
        
        stream.Close();
      
        return sd;
    }
    */
}
