using System;

public class PhoneBook
{

	string[] Names;
	long[] Numbers;
	int size;

	public PhoneBook(int _size)
	{
		this.size = _size;
		Names = new string[_size];
		Numbers = new long[_size];
	}

	//Indexer
	public string this[int index]
	{
		get { return Names[index]; }
		set { Names[index] = value; }
	}

	public void SetEntry(int index, string name, long numbers)
	{
		Names[index] = name;
		Numbers[index] = numbers;
	}

	//Get index/number of the name
	public int getNumber(string Name)
	{
		for (int i =0; i<Names.Length;i++)
		{
			if (Names[i] == Name)
			{
				return i;
			}
		
		}
        return -1;//Not found
    }


}
