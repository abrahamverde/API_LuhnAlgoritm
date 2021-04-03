# API Luhn Algorithm

API Luhn Algorithm is a demo program to show how you can generate and validate numbers ruled by Luhn Algoritm. This is an API built NET Core 5.0 - C#. Remember that credit cards usually use Luhn Numbers, so you can check is a credit card number is valid using validate endopoint of this API.

In this link, you can get info about Luhn Algorithm. [Luhn Algorithm Wikipedia](https://en.wikipedia.org/wiki/Luhn_algorithm)


## Dependencies

![](https://img.shields.io/badge/dependencies-dotnetCore-red) 


# Usage
### Endpoint Generate
The API has two endpoints, one of them is Generate. This endpoint will generate a valid Luhn random number of 16 digits. 

### Endpoint Validate
The other endpoint of this API is Validate. This endpoint receive a number that you want to validate, and API return you true or false depends luhn's rules


## License

MIT License

Copyright (c)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
