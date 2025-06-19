# MultiShop - E-Ticaret Mikroservis Projesi

Bu proje, .NET kullanılarak mikroservis mimarisiyle oluşturulmuş kapsamlı bir e-ticaret platformudur. Proje, her iş yeteneğinin özel bir servis tarafından yönetildiği, ölçeklenebilir, sürdürülebilir ve esnek olacak şekilde tasarlanmıştır.

## Mimari

Uygulama, istekleri uygun arka uç hizmetlerine yönlendiren merkezi bir API Gateway ile mikroservis modelini takip eder. Kimlik doğrulama ve yetkilendirme, özel bir IdentityServer tarafından yönetilir.

*<-- Mimari şeması için yer tutucu -->*

### Ana Bileşenler

*   **API Gateway**: Tüm istemci istekleri için **Ocelot** ile oluşturulmuş tek bir giriş noktası.
*   **Identity Service**: **IdentityServer4** kullanan merkezi bir kimlik doğrulama ve yetkilendirme hizmeti.
*   **Frontend**: **ASP.NET Core MVC** ile oluşturulmuş kullanıcıya yönelik bir web uygulaması.
*   **Backend Servisleri**: Her biri belirli bir iş alanından sorumlu olan bağımsız servisler topluluğu.

### Arayüz Teknolojileri
Kullanıcı arayüzü, **ASP.NET Core MVC** üzerine kurulu olup, modern ve dinamik bir kullanıcı deneyimi sunmak için çeşitli istemci taraflı kütüphanelerden yararlanır. Proje, hazır HTML5 şablonları (`online-shop-website-template` ve `OvioAdmin`) üzerine inşa edilmiştir.

*   **Tasarım ve Düzen (Layout)**: **Bootstrap** framework'ü kullanılarak responsive (duyarlı) bir tasarım elde edilmiştir.


## Kullanılan Teknolojiler

*   **Backend**: .NET 6.0, ASP.NET Core
*   **Veri Erişimi**: Entity Framework Core, Dapper
*   **Mimari ve API**: Mikroservis, REST API, Ocelot API Gateway
*   **Kimlik Doğrulama**: IdentityServer4 (OAuth 2.0 & OpenID Connect)
*   **Veritabanları**: SQL Server, MongoDB, Redis
*   **Frontend**: Bootstrap, jQuery, jQuery Validation, Owl Carousel, Animate.css
*   **Diğer**: AutoMapper

## Servisler

| Servis         | Açıklama                                              | Veritabanı     |
|----------------|-------------------------------------------------------|----------------|
| **Catalog**    | Ürünleri, kategorileri ve markaları yönetir.          | MongoDB        |
| **Basket**     | Kullanıcı alışveriş sepetlerini yönetir.              | Redis          |
| **Discount**   | Kuponları ve promosyon indirimlerini yönetir.         | SQL Server     |
| **Order**      | Müşteri siparişlerini ve sipariş geçmişini yönetir.   | SQL Server     |
| **Cargo**      | Kargo ve takip bilgilerini yönetir.                   | SQL Server     |
| **Comment**    | Ürünler hakkındaki kullanıcı yorumlarını yönetir.     | SQL Server     |

## Projeyi Başlatma

Bu projeyi yerel olarak çalıştırmak için aşağıdaki araçlara ihtiyacınız olacak:

*   [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
*   [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) veya [VS Code](https://code.visualstudio.com/)
*   [Docker Desktop](https://www.docker.com/products/docker-desktop)
*   [Portainer](https://www.portainer.io/) (Docker konteynerlarını yönetmek için isteğe bağlı)

### 1. Veritabanı Kurulumu
Her servisin kendi veritabanı vardır ve bağlantı dizeleri (connection string) ilgili servis projesinin `appsettings.json` dosyasında bulunur. Docker üzerinden veritabanlarını başlattıktan sonra bu bağlantı dizelerinin doğru olduğundan emin olun.


