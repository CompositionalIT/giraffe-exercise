# Giraffe Exercises
Also see [here](https://github.com/giraffe-fsharp/Giraffe/blob/master/README.md) and [here](https://github.com/giraffe-fsharp/Giraffe/blob/master/DOCUMENTATION.md) for useful documentation on Giraffe.

## Task 1: Text Endpoint
Create a basic Giraffe web application which returns "Hello world" when visiting http://localhost:5000. The response type should be `text/plain`.

## Task 2: JSON Endpoint
Change the response type to a valid JSON mime type and return the `Hello world` greeting as part of a JSON object.
For example, when I visit http://localhost:5000 I want to get the following HTTP response back:

```json
{ "message": "Hello world" }
```

## Task 3: Query Strings
Accept a query parameter called `lang` and return the greeting in one of the following supported languages:
    1. English
    2. Spanish
    3. French
    4. German

If a language is provided which is not supported then return a HTTP 400 Bad Request response with a message saying that the selected language is not supported and give a list of supported languages.

For example, visiting http://localhost:5000?lang=en should return:

200 OK

```json
{ "message": "Hello world" }
```

Visiting http://localhost:5000?lang=de should return:

200 OK

```json
{ "message": "Hallo Welt" }
```

However, calling http://localhost:5000?lang=nl (Dutch) should return:

400 Bad Request

```json
{ "error": "nl is not a supported language at the moment. Currently supported languages are: en (English), es (Spanish), fr (French), de (German)." }
```

The `lang` query parameter should accept a two character ISO 639-1 value (see: https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes).

## Task 4: Working with App Settings
Extend on task 3 and make the list of supported languages configurable via appsettings.json. It is ok to hard code a JSON dictionary of supported language codes and the corresponding greeting in the appsettings.json file.

## Task 5: Routing
Make the current endpoint you have made only work on a specific route, `/api/greet`. Any other endpoint should return a 404.

## Task 6: Verbs
Make the current endpoint only work for GET requests. Any other verb should return a 404.

## Task 7: URL parameterisation
Change from using the query string to the uri path instead: `/api/greet/de` or `/api/greet/en` etc.

## Task 8: Request Body
Change from using the URI path to parsing the body of a POST request to `/api/greet/`. The body should look something like:

```json
{ "language": "DE" }
```

## Task 9: Multiple routes
Create multiple routes:

* `/api/greet` which works via a POST as currently.
* `/api/greet/querystring` which works with the query string as per Task 4.
* `/api/greet/<country code>` which works with a URI parameter as per Task 7.