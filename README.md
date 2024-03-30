# Serilog ile Web API Loglama

Bu proje, Serilog kütüphanesini kullanarak .NET Core Web API uygulamalarında loglama işlemlerini gerçekleştirmeyi sağlar. Proje içerisinde dört farklı proje bulunmaktadır, her biri farklı loglama hedeflerine sahiptir.

## Projeler

1. **Logger.API**: Bu proje, sadece konsola loglama yapar.
2. **Logger.ToFile.API**: Bu proje, logları bir dosyaya kaydeder.
3. **Logger.ToMSSql.API**: Bu proje, logları bir MSSQL veritabanına kaydeder.
4. **Logger.ToSeq.API**: Bu proje, logları hem Seq'e hem de özel bir yapı ile MSSQL veritabanına kaydeder.

## Kullanım

Her bir proje için kullanım aşağıdaki adımları içerir:

1. Proje dizinine gidin: `cd Logger.API` (örneğin)
2. Projeyi derleyin: `dotnet build`
3. Projeyi çalıştırın: `dotnet run`

Her bir proje kendi loglama hedefini yapılandırmak için Serilog konfigürasyonunu içerir. Daha fazla ayrıntı için ilgili proje dosyalarını inceleyebilirsiniz.

## Destek

Sorularınız veya geri bildiriminiz varsa, lütfen [turkmvc@gmail.com](mailto:turkmvc@gmail.com) adresine e-posta gönderin veya bir konu açın.

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasını inceleyebilirsiniz.
