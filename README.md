# WeAreTheChampions


https://user-images.githubusercontent.com/79913799/138124202-50538669-d00f-4f60-acb0-f84131a65f33.mp4



# Bir Windows Form Uygulaması

<p>Bu uygulamanın amacı gerek gerçek spor takımları gerekse arkadaşlarınız arasında yapacağınız sportif aktiviteler için takımların, oyuncuların ve takımlar arası maçların bilgilerinin saklanması ve yönetilmesidir.</p>

## Uygulama Akışı

<p>Maçlar takımlar arasında olur ve takımlar oyunculardan oluşur.</p>
<p>Önce takımlar oluşturulur. Takımların istenirse renkleri de belirtilebilir.</p>
<p>Sonra oyuncular oluşturulur. Her oyuncunun ait olduğu en fazla bir takım olabilir ancak istenirse bir oyuncu takımsız da oluşturulabilir. Diğer bir deyişle, her oyuncu bir takımda oynamak zorunda değildir ve birden fazla takımda aynı anda da oynayamaz.</p>
<p>Takımlar arasında belirli tarih ve saatte karşılaşma planlanır. Maç sonrasında uygulama üzerinden karşılaşma skoru girilebilmelidir.</p>

## Varlık Birimleri ve Özellikleri

    | Team          | Color         | TeamColor     | Player                     |
    | ------------- | ------------- | ------------- | -------------------------- |
    | Id            | Id            | TeamId        | Id                         |
    | TeamName      | ColorName     | ColorId       | TeamId (İsteğe bağlı)      |
    |               | Red (0-255)   |               | PlayerName                 |
    |               | Green (0-255) |               |                            |
    |               | Blue (0-255)  |               |                            |

    | Match                                                                                       | 
    | ------------------------------------------------------------------------------------------- | 
    | Id                                                                                          |
    | MatchTime                                                                                   | 
    | Team1Id (Zorunlu)                                                                           | 
    | Team2Id (Zorunlu)                                                                           | 
    | Score1                                                                                      | 
    | Score2                                                                                      |
    | Result (NULL: belli değil, 0: berabere, 1: Team1 kazandı, 2: Team2 kazandı)                 | 


## Ara Yüz

### 1. Karşılama Ekranı

<p>Bu ekranda planlanmış maçlar listelenir. Maça çift tıklayarak ya da düzenle butonuna basarak detaylarına gidip değişiklik yapabilirsiniz. Bu ekranda maçlar en ileri tarihliden en geçmişe doğru sıralanmalıdır. Kullanıcı isterse oynanmış maçları gizleyebilmelidir.</p>

### 2. Yeni Karşılaşma

<p>
    Bu görünümde seçilen 2 takım arasında yine kullanıcının belirteceği tarih ve saatte maç oluşturulabilecektir. Yapılan değişiklikler ana sayfaya yansıtılır.
    3. Karşılaşma Düzenle
</p>
<p>Bu görünüm yukarıdaki görünümle benzerdir. Yeni Karşılaşma görünümden farklı olarak form öğeleri düzenlenmek istenen karşılaşmanın verileriyle gösterilir ve düzenleme imkanı sağlanır. Yapılan değişiklikler ana sayfaya yansıtılır.</p>

### 4. Renkler

<p>Bu görünümde kullanıcı renk tanımlayabilir, düzenleyebilir ve silebilir. Renklere ait 4 ana bilgi vardır. Renk adı ve RGB değerleri. Kullanıcıya renk seçtirilir ve seçilen rengin R, G ve B değerleri renk adıyla birlikte veritabanına kaydedilir. Örneğin bordo renginin rgb değerleri sırayla 128, 0, 0 ’dır.</p>

### 5. Takımlar

<p>Bu görünümde takım adıyla birlikte takımlar oluşturulur ve düzenlenir. Oluşan takımlara önceden tanımlanmış renklerden renk eklenebilir. Takımlar istenilen sayıda renge sahip olabilir. Renk opsiyoneldir ve renk sayısında kısıtlama yoktur. Ayrıca bir takım seçildikten sonra Oyuncular butonuna basıldığında yeni bir görünümde seçilen takıma önceden tanımlanmış oyuncu ekleme/çıkarma yapılabilmedir.</p>

### 6. Oyuncular

<p>
    Oyuncuların listelendiği ve düzenlenildiği görünümdür. Bu görünümde yeni oyuncu ekleyip silinebilmelidir. Oyuncu eklenirken istenirse takım da seçilebilir. Oyuncular listelenirken takıma göre filtreleme yapılabilmedir.
    Not: Karşılama ekranı örnek olarak verilmiştir. Arayüzde ve veritabanı tasarımında ihtiyaca uygun olarak değişiklikler yapabilirsiniz.
</p>
