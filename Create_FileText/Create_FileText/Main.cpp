#include <iostream>

#include <fstream>

using namespace std;

void main()
{
	ofstream outputStream = ofstream();
	const int bufferSize = 248;
	char text[bufferSize];

	outputStream.open("Text.txt");

	cin.get(text, bufferSize);

	outputStream << text;

	outputStream.close();

}