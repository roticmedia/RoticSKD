For initialize:
```
            Connect Rotic = new Connect();
            var Data = Rotic.init(YOUR_TOKEN);
            Console.WriteLine(Data.response.domain);
```
For chat:
```
            Connect Rotic = new Connect();
            var Data = Rotic.chat(YOUR_TOKEN,YOUR_MESSAGE);
            Console.WriteLine(Data.response);
```
For detect language:
```
            Connect Rotic = new Connect();
            var Data = Rotic.detectLanguage(YOUR_TOKEN,YOUR_MESSAGE);
            Console.WriteLine(Data.response.language);
```
For detect time:
```
            Connect Rotic = new Connect();
            var Data = Rotic.detectTime(YOUR_TOKEN,YOUR_MESSAGE);
            Console.WriteLine(Data.response[0].initial_word);
```