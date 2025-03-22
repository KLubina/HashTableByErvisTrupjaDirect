using System;
using System.Collections;

//the hashtable is used to store key-value pairs
//key and value can be of any data type
//there must be a key but value can be null
namespace HashTableByErvisTrupja
  {
  class Program
    {
    static void Main( string[] args )
      {
      //create hashtable object
      Hashtable myHashtable = new Hashtable()
      //first way to intiialize (in the yt-video at 01:43)
        {
          { 3, "Three"},
          { "another", 78.5}
        };
      //initialize hashtable and add values
      myHashtable.Add( 1, "One" );
      myHashtable.Add( "2", "Two" );

      //print out hashtable content
      Hashtable myHashtablePrintOut = new Hashtable( myHashtable );

      string valueOfOne = (string) myHashtablePrintOut[ 1 ];
      Console.WriteLine( $"Value of One = {valueOfOne}" );
      }
    }
  }
