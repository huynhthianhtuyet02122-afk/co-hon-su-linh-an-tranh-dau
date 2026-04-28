# Cơ Hồn Sư: Linh Ấn Tranh Đấu

## Game Design Concept Document — Bản sắp xếp chuyên nghiệp

**Tên tạm thời:** Cơ Hồn Sư: Linh Ấn Tranh Đấu  
**Tên quốc tế đề xuất:** Soul Cue: Ascension  
**Nền tảng định hướng:** Unity 3D  
**Hình thức chơi:** Offline single-player  
**Giai đoạn hiện tại:** Ý tưởng / tiền sản xuất / làm game design board  
**Trạng thái kỹ thuật:** Chưa tạo Unity project, chưa bắt đầu code

---

# 0. Tóm tắt điều hành

_Cơ Hồn Sư: Linh Ấn Tranh Đấu_ là game 3D fantasy hiện đại, phong cách anime, kết hợp **bi-da chiến thuật**, **RPG**, **leo rank offline**, **khám phá Đảo Lưu Đày** và **cốt truyện bí ẩn**.

Trong thế giới game, tổ chức **Thiên Khung Hội** tạo ra trò chơi toàn cầu tên **Linh Cơ Đấu**. Người chơi trở thành **Cơ Hồn Sư**, dùng gậy cơ ma thuật để điều khiển các viên **Linh Cầu** trên bàn đấu. Mỗi Linh Cầu đại diện cho một **Linh Ấn** bên trong người chơi. Khi Linh Cầu bị đánh vào lỗ, Linh Ấn tương ứng bị phong ấn tạm thời.

Người chơi tham gia để leo rank, mạnh hơn và tìm sự thật về **An Nhiên**, người quan trọng đã biến mất sau một trận đấu cấp cao tại **Thần Cơ Tháp**.

Sự thật dần hé lộ: Linh Cơ Đấu không chỉ là môn thể thao đổi đời. Nó là một hệ thống huấn luyện, sàng lọc và thu thập Linh Lực để chuẩn bị cho biến cố **Đại Sụp Linh**. Phản diện chính **Elias Vân** muốn dựng **Thiên Khung Trận** để bảo vệ thế giới, nhưng cách làm của ông biến con người thành nhiên liệu và tước đi quyền lựa chọn của họ.

---

# 1. Trụ cột thiết kế

## 1.1. Trụ cột gameplay

- Đấu bi-da ma thuật.
- Mỗi viên bi là một phần sức mạnh / Linh Ấn.
- Thua không game over mà mở ra gameplay khám phá Đảo Lưu Đày.
- Leo rank bằng hệ thống 5 sao.
- Cơ Hồn Thẻ vừa là menu gameplay, vừa là công cụ kể chuyện.
- Game offline nhưng vẫn có cảm giác thi đấu trong một hệ thống rank toàn cầu.

## 1.2. Trụ cột cảm xúc

- Danh vọng.
- Áp lực phải mạnh hơn.
- Cái giá của việc leo rank.
- Đánh mất bản thân để được công nhận.
- Tìm lại chính mình sau thất bại.
- Cứu thế giới mà không tước quyền lựa chọn của con người.

## 1.3. Trụ cột hình ảnh

- Anime fantasy 3D cao cấp.
- Thành phố hiện đại kết hợp ma thuật.
- Đấu trường có ánh sáng, hologram, pháp trận.
- Bàn bi-da như trận địa Linh Lực.
- Linh Cầu phát sáng như tinh thể.
- Gậy cơ giống vũ khí / ma pháp khí.

## 1.4. Nguyên tắc sản xuất

- Không làm MVP thử rời rạc.
- Unity project đầu tiên là project chính thức.
- Mỗi hệ thống được code ra phải dùng tiếp lâu dài.
- Ưu tiên kiến trúc sạch, dễ mở rộng.
- Không nhồi scope quá lớn vào giai đoạn đầu.

---

# 2. Thông tin dự án

## 2.1. Thể loại

- 3D fantasy hiện đại.
- Anime fantasy.
- Bi-da chiến thuật.
- Fantasy RPG.
- Leo rank offline.
- Phiêu lưu 3D.
- Thu thập skin, gậy cơ, hiệu ứng.
- Cốt truyện bí ẩn.

## 2.2. Định hướng không sao chép

Game có thể lấy cảm hứng về độ chỉn chu, độ đẹp và cảm giác anime fantasy cao cấp từ các game lớn như Genshin Impact, nhưng **không sao chép trực tiếp** thế giới, nhân vật, gameplay hoặc phong cách nhận diện.

## 2.3. Thông điệp trung tâm

> Muốn trở thành Cơ Hồn Sư mạnh nhất, trước tiên phải giữ được linh hồn của chính mình.

Thông điệp phụ:

> Mỗi trận thua không lấy đi con người bạn. Nó chỉ cho bạn thấy phần nào của mình cần được tìm lại.

---

# 3. Thế giới & bối cảnh

## 3.1. Thế giới fantasy hiện đại

Game diễn ra trong một thế giới nơi thành phố, công nghệ, livestream, quảng cáo, bảng xếp hạng, giải đấu và mạng xã hội cùng tồn tại với nguồn năng lượng cổ xưa gọi là **Linh Lực**.

Linh Lực tồn tại bên trong mỗi con người. Nó ảnh hưởng đến:

- Tài năng.
- Cảm xúc.
- Sức khỏe.
- Ý chí.
- Tiềm năng.
- Khả năng biểu hiện Linh Ấn.

## 3.2. Tân Linh Đô

**Tân Linh Đô** là thành phố chính, nơi người chơi bắt đầu hành trình.

Vai trò:

- Trung tâm đăng ký Linh Cơ Đấu.
- Nơi diễn ra Nghi Thức Tạo Linh Xác.
- Nơi người chơi gặp Mika và Lâm Vô Cơ.
- Không gian thể hiện cơn sốt Linh Cơ Đấu.
- Thành phố mở đầu cho câu chuyện danh vọng và mặt tối phía sau bảng xếp hạng.

## 3.3. Linh Cơ Đấu

**Linh Cơ Đấu** là trò chơi / môn thể thao toàn cầu do Thiên Khung Hội tạo ra.

Bên ngoài, nó được xem là:

- Cơ hội đổi đời.
- Môn thể thao mới.
- Hệ thống leo rank.
- Nơi người trẻ trở thành ngôi sao.
- Nơi các Cơ Hồn Sư nổi tiếng xuất hiện trên truyền thông.

Sự thật:

- Đây là hệ thống thu thập Linh Lực.
- Bảng xếp hạng là bộ lọc.
- Đấu trường là mắt trận của Thiên Khung Trận.
- Người chơi mạnh có thể bị chọn làm Chân Cơ Hồn.

## 3.4. Linh Giới

**Linh Giới** là không gian nguồn gốc của Linh Lực.

Đặc điểm:

- Nằm sau ranh giới giữa thế giới con người và năng lượng cổ xưa.
- Có liên hệ với Đảo Lưu Đày.
- Có thể chứa ký ức, Linh Ấn thất lạc và Linh Xác bị phân mảnh.
- Là nơi An Nhiên có thể đang bị phong tỏa.
- Khi ranh giới suy yếu, Linh Giới có thể xâm thực thế giới con người.

## 3.5. Đại Sụp Linh

**Đại Sụp Linh** là biến cố lớn: ranh giới giữa thế giới con người và Linh Giới ngày càng suy yếu.

Dấu hiệu ban đầu:

- Một số người nghe tiếng gọi từ Linh Giới trong giấc mơ.
- Linh Cầu tự phát sáng.
- Một số khu vực xuất hiện méo không gian.
- Người có Linh Ấn mạnh mất kiểm soát cảm xúc.
- Linh Xác thử nghiệm bị vỡ hoặc biến dạng khi đồng bộ.

Hậu quả nếu Đại Sụp Linh xảy ra:

- Người bình thường mất kiểm soát Linh Ấn.
- Linh Xác rối loạn hoặc tan vỡ.
- Thành phố bị Linh Giới xâm thực.
- Thực thể Linh Giới xuất hiện.
- Người yếu Linh Lực có thể bị nuốt mất bản ngã.
- Ranh giới giữa ký ức, khát vọng và hiện thực bị xóa nhòa.

---

# 4. Thiên Khung Hội & xung đột trung tâm

## 4.1. Thiên Khung Hội

**Tên tổ chức:** Thiên Khung Hội  
**Tên quốc tế:** The Ark

Bên ngoài, Thiên Khung Hội là tập đoàn giải trí, công nghệ và thể thao toàn cầu.

Khẩu hiệu công khai:

> Đưa con người đến giới hạn cao nhất của tiềm năng.

Vai trò công khai:

- Tổ chức Linh Cơ Đấu.
- Xây đấu trường lớn.
- Tạo bảng xếp hạng toàn cầu.
- Tài trợ giải đấu.
- Tạo ra idol Cơ Hồn Sư.
- Mở học viện đào tạo Cơ Hồn Sư.

Vai trò thật:

- Huấn luyện con người chuẩn bị cho Đại Sụp Linh.
- Thu thập Linh Lực.
- Sàng lọc người có tiềm năng.
- Tìm Chân Cơ Hồn.
- Dựng Thiên Khung Trận.

## 4.2. Thiên Khung Trận

**Thiên Khung Trận** là kết giới khổng lồ bảo vệ thế giới con người trước Đại Sụp Linh.

Cấu trúc:

- Mỗi đấu trường lớn là một mắt trận.
- Thần Cơ Tháp là lõi chính.
- Linh Cơ Đấu là công cụ thu thập và dẫn truyền Linh Lực.
- Bảng xếp hạng là hệ thống đánh giá khả năng chịu Linh Lực.

Các đấu trường đóng vai trò mắt trận:

- Tân Cơ Đài.
- Đồng Thành Arena.
- Ngân Hải Đài.
- Kim Quang Palace.
- Huyền Thạch Dome.
- Tinh Vân Court.
- Thần Cơ Tháp.

Thiên Khung Trận cần:

- Lượng Linh Lực cực lớn.
- Linh Lực tinh khiết.
- Một lõi sống để điều phối năng lượng.

## 4.3. Chân Cơ Hồn

**Chân Cơ Hồn** là cá thể có thể làm lõi sống cho Thiên Khung Trận.

Đặc điểm:

- Cộng hưởng với nhiều loại Linh Ấn.
- Chịu được Linh Lực hỗn loạn.
- Kết nối được thế giới con người và Linh Giới.
- Tái tạo Linh Ấn đã vỡ.
- Giữ bản ngã ổn định dù bị phong ấn nhiều lần.

Ý nghĩa trong cốt truyện:

- An Nhiên từng là ứng viên Chân Cơ Hồn đời trước.
- Nhân vật chính là ứng viên mới.
- Elias muốn dùng người chơi làm lõi sống cho Thiên Khung Trận.

## 4.4. Elias Vân

**Vai trò:** Phản diện chính / Chủ tịch Thiên Khung Hội / phản diện tư tưởng.

Elias không xem mình là kẻ ác. Ông tin rằng:

- Nhân loại hiện tại quá yếu.
- Nếu nói thẳng về Đại Sụp Linh, thế giới sẽ hỗn loạn.
- Nếu biến chuẩn bị thảm họa thành trò chơi, con người sẽ tự nguyện mạnh lên.
- Sự hy sinh của một số người là cái giá cần thiết để bảo vệ tương lai.

Câu thoại tư tưởng:

> Nếu ta nói thảm họa sắp đến, họ sẽ hoảng loạn. Nếu ta biến nó thành trò chơi, họ sẽ tự nguyện mạnh lên.

Câu thoại nguy hiểm:

> Ta không hy sinh nhân loại. Ta chỉ hy sinh những phần yếu đuối đang giữ nhân loại ở lại.

Tội lỗi thật sự:

- Che giấu sự thật.
- Biến danh vọng thành cơn nghiện.
- Để người chơi đánh cược Linh Ấn mà không hiểu cái giá thật.
- Dùng người thua, người mắc kẹt và Cơ Hồn Sư rank cao làm nhiên liệu.
- Tước quyền lựa chọn của con người.

Câu chốt:

> Elias không muốn hủy diệt thế giới. Ông muốn cứu thế giới bằng cách tước quyền lựa chọn của nó.

---

# 5. Người chơi, Linh Xác & An Nhiên

## 5.1. Nhân vật chính

Người chơi không nhập vai vào một nhân vật cố định. Người chơi được tự chọn:

- Tên.
- Giới tính.
- Ngoại hình.
- Kiểu tóc.
- Khuôn mặt.
- Trang phục ban đầu.
- Màu Linh Lực.
- Biểu tượng Linh Ấn cá nhân.
- Gậy cơ đầu tiên.

Nền tảng cốt truyện chung:

- Người bình thường tại Tân Linh Đô.
- Không có Linh Ấn nổi bật.
- Không thuộc học viện danh tiếng.
- Không có đội tuyển chống lưng.
- Không có nhà tài trợ.
- Bị hệ thống đánh giá tiềm năng thấp.

Điểm đặc biệt:

- Có **Linh Ấn Không Xác Định**.
- Có khả năng cộng hưởng và liên kết lại Linh Ấn đã vỡ.
- Có thể tìm lại bản thân nhanh hơn người khác sau thất bại.
- Có thể là ứng viên Chân Cơ Hồn.

## 5.2. Linh Xác

**Linh Xác** là thân thể chiến đấu của người chơi trong đấu trường và Linh Giới.

Linh Xác được tạo từ:

- Ký ức cá nhân.
- Khát vọng.
- Nỗi sợ.
- Tính cách.
- Linh Ấn bên trong người chơi.

Ý nghĩa:

> Linh Xác là phiên bản mà người chơi muốn trở thành, nhưng cũng là nơi phản chiếu con người thật của họ.

Mặt tối:

> Càng dùng Linh Xác lâu, người chơi càng dễ quên mất bản thân thật sự của mình.

## 5.3. Nghi Thức Tạo Linh Xác

Màn tạo nhân vật được gọi là **Nghi Thức Tạo Linh Xác**.

Người chơi chọn:

- Dáng người.
- Khuôn mặt.
- Kiểu tóc.
- Trang phục ban đầu.
- Màu Linh Lực.
- Kiểu gậy cơ đầu tiên.
- Biểu tượng Linh Ấn cá nhân.

Kết quả quét Linh Ấn:

```text
Ấn Thủ: chưa ổn định
Ấn Nhãn: chưa ổn định
Ấn Túc: chưa ổn định
Ấn Tâm: dao động
Ấn Trí: không xác định
Ấn Khí: không xác định
Ấn Hồn: lỗi phân tích

Kết luận: Linh Ấn Không Xác Định
```

## 5.4. An Nhiên

**Vai trò:** Người quan trọng đã biến mất / động lực cảm xúc chính.

Có thể là:

- Chị gái.
- Anh trai.
- Bạn thân.
- Mentor.
- Người thầy đầu tiên.

An Nhiên từng tham gia trận đấu cấp cao tại **Thần Cơ Tháp** và biến mất khỏi bảng xếp hạng. Thiên Khung Hội tuyên bố An Nhiên tự rút lui, nhưng người chơi tìm thấy một viên Linh Cầu nứt còn lưu lại lời cảnh báo:

> Nếu em nghe được điều này, đừng tin bảng xếp hạng.

Vai trò mới đã chốt:

- An Nhiên từng là ứng viên Chân Cơ Hồn đời trước.
- An Nhiên phát hiện sự thật về Thiên Khung Hội.
- An Nhiên từ chối trở thành lõi sống.
- Elias không giết An Nhiên nhưng phong tỏa sự tồn tại của An Nhiên trong tầng sâu Linh Giới.
- Người chơi đang đi lại con đường An Nhiên từng đi dở.

---

# 6. Hệ thống Linh Ấn

## 6.1. Khái niệm

Mỗi người tham gia Linh Cơ Đấu sở hữu một bộ Linh Ấn. Linh Ấn được thể hiện bằng các viên **Linh Cầu** trên bàn đấu.

Khi một Linh Cầu rơi vào lỗ:

- Linh Ấn tương ứng bị phong ấn tạm thời.
- Cơ thể / trang phục mờ aura.
- Biểu tượng Linh Ấn nứt vỡ.
- UI thông báo trạng thái phong ấn.

## 6.2. Bộ Linh Ấn cơ bản

| Linh Ấn | Đại diện              | Khi bị phong ấn                        |
| ------- | --------------------- | -------------------------------------- |
| Ấn Thủ  | Điều khiển lực đánh   | Lực đánh yếu hoặc khó ổn định          |
| Ấn Nhãn | Quan sát              | Đường ngắm ngắn hơn, khó thấy hướng bi |
| Ấn Túc  | Di chuyển             | Di chuyển chậm hơn ở Đảo Lưu Đày       |
| Ấn Tâm  | Ý chí / tinh thần     | Dễ bị hiệu ứng bất lợi                 |
| Ấn Trí  | Phân tích chiến thuật | Mất gợi ý đường bi hoặc gợi ý sai lệch |
| Ấn Khí  | Năng lượng kỹ năng    | Kỹ năng hồi chậm hơn                   |
| Ấn Hồn  | Linh lực cốt lõi      | Rơi vào trạng thái nguy hiểm           |

## 6.3. Màu và hiệu ứng Linh Ấn

| Linh Ấn | Màu / biểu tượng                    |
| ------- | ----------------------------------- |
| Ấn Thủ  | Đỏ / cam, biểu tượng bàn tay        |
| Ấn Nhãn | Xanh lam, biểu tượng mắt            |
| Ấn Túc  | Vàng, biểu tượng bước chân          |
| Ấn Tâm  | Hồng / tím, biểu tượng ý chí        |
| Ấn Trí  | Trắng / xanh, biểu tượng tinh thể   |
| Ấn Khí  | Xanh ngọc, dòng năng lượng          |
| Ấn Hồn  | Đen tím pha vàng, hiếm và nguy hiểm |

## 6.4. Animation phong ấn

1. Linh Cầu rơi xuống lỗ.
2. Pháp trận sáng lên.
3. Biểu tượng Linh Ấn vỡ thành mảnh sáng.
4. Nhân vật mất một lớp aura.
5. UI hiện thông báo: “Ấn Nhãn đã bị phong ấn.”

---

# 7. Gameplay loop

## 7.1. Vòng lặp chính

1. Vào sảnh chính.
2. Chọn trận đấu.
3. Đấu Linh Cơ Đấu.
4. Nếu thắng: nhận thưởng, hồi phục, +1 sao rank.
5. Nếu đủ 5 sao: mở Trận Thăng Rank.
6. Nếu thua: mất sao nếu còn sao, luôn vào Đảo Lưu Đày.
7. Tìm lại Linh Ấn.
8. Quay về sảnh chính.
9. Tiếp tục leo rank.
10. Mở khóa cốt truyện mới.

## 7.2. Hai trục gameplay chính

- Đấu bi-da ma thuật để leo rank.
- Khám phá Đảo Lưu Đày để tìm lại bản thân sau thất bại.

---

# 8. Luật thắng thua

## 8.1. Khi thắng trận thường

Người chơi nhận:

- Hồi phục toàn bộ Linh Ấn trong trận.
- +1 sao rank.
- Kinh nghiệm.
- Vàng / tiền tệ.
- Vật phẩm nâng cấp.
- Nguyên liệu mở skin.
- Mảnh ký ức / cốt truyện.
- Quyền mở trận, đấu trường hoặc nhiệm vụ mới nếu đạt điều kiện.

## 8.2. Khi đủ 5 sao

Mỗi rank có 5 sao. Khi đủ 5 sao, Cơ Hồn Thẻ mở khóa **Trận Thăng Rank**.

Nếu thắng Trận Thăng Rank:

- Lên rank mới.
- Sao trở về 0/5 ở rank mới.
- Mở đấu trường, đối thủ, kỹ năng, nhiệm vụ hoặc khu vực mới.

Nếu thua Trận Thăng Rank:

- Mất 1 sao.
- Bị đưa đến Đảo Lưu Đày.
- Phải tìm lại Linh Ấn trước khi quay về đấu trường.

## 8.3. Khi thua

Thua chỉ có một loại.

Luật:

- Nếu đang có 1–5 sao: mất 1 sao.
- Nếu đang có 0 sao: không mất sao và không rớt rank ở bản cơ bản.
- Dù có bao nhiêu sao, người chơi luôn bị đưa đến Đảo Lưu Đày.
- Một hoặc nhiều Linh Ấn bị thất lạc.
- Quyền thi đấu bị tạm khóa.
- Người chơi phải hoàn thành thử thách trên đảo để quay lại.

Điểm chốt:

> Đảo Lưu Đày là hình phạt chính sau khi thua. Không cần rớt rank ở bản cơ bản để tránh gây nản.

---

# 9. Hệ thống rank & Cơ Hồn Thẻ

## 9.1. Hệ thống rank

Game là offline single-player nên không dùng điểm rank phức tạp. Game dùng **5 sao mỗi rank**.

Danh sách rank:

1. Tân Cơ Thủ.
2. Đồng Linh.
3. Bạc Ấn.
4. Hoàng Kim.
5. Bạch Kim.
6. Huyền Thạch.
7. Tinh Vân.
8. Thần Cơ.
9. Vô Cực.

Luật sao:

- Thắng trận thường: +1 sao.
- Thua trận: nếu có sao thì -1 sao.
- 0 sao thua: không mất sao, không rớt rank, vẫn vào Đảo Lưu Đày.
- Đủ 5 sao: mở Trận Thăng Rank.
- Thắng Trận Thăng Rank: lên rank mới, sao về 0/5.
- Thua Trận Thăng Rank: còn 4/5 sao, vào Đảo Lưu Đày.

## 9.2. Trận Thăng Rank

Tiến trình đề xuất:

| Rank        | Đối thủ / mốc thăng rank |
| ----------- | ------------------------ |
| Tân Cơ Thủ  | Bách                     |
| Đồng Linh   | Yuna                     |
| Bạc Ấn      | Raven                    |
| Hoàng Kim   | Seraphina                |
| Bạch Kim    | Hạo Nhiên                |
| Huyền Thạch | Vệ Cơ Sứ                 |
| Tinh Vân    | Thần Cơ Tháp             |
| Thần Cơ     | Elias Vân                |

## 9.3. Cơ Hồn Thẻ

**Cơ Hồn Thẻ** là vật phẩm vừa có vai trò gameplay, vừa có vai trò cốt truyện.

Trong gameplay, thẻ dùng để xem:

- Hồ sơ nhân vật.
- Rank hiện tại.
- Số sao hiện tại.
- Điều kiện Trận Thăng Rank.
- Trạng thái Linh Ấn.
- Linh Xác.
- Gậy cơ đang trang bị.
- Hệ Linh Lực.
- Nhiệm vụ chính / phụ.
- Mảnh ký ức đã thu thập.

Trong cốt truyện:

- Ban đầu là menu hỗ trợ.
- Về sau hiện dữ liệu lạ.
- Cho thấy Thiên Khung Hội đang theo dõi người chơi.
- Dần hé lộ dữ liệu về Chân Cơ Hồn.

Ví dụ dữ liệu lạ:

```text
Cộng hưởng Linh Ấn: bất thường
Tỉ lệ thích nghi Thiên Khung Trận: 17%
Dữ liệu bị khóa
Ứng viên Chân Cơ Hồn: đang đánh giá
Cảnh báo: không được rời khỏi hệ thống
```

## 9.4. Menu Cơ Hồn Thẻ

```text
Cơ Hồn Thẻ
├── Hồ sơ
├── Rank
├── Linh Ấn
├── Linh Xác
├── Gậy cơ
├── Nhiệm vụ
└── Ký ức
```

---

# 10. Đảo Lưu Đày

## 10.1. Vai trò

Đảo Lưu Đày là nơi những Cơ Hồn Sư thất bại bị đưa đến để tìm lại Linh Ấn.

Nó không chỉ là nơi hồi phục mà còn là nơi chứa bí mật của thế giới.

Trên đảo có:

- Người chơi khác bị mắc kẹt.
- NPC từng là Cơ Hồn Sư nổi tiếng.
- Mảnh Linh Ấn thất lạc.
- Câu đố liên quan đến từng Linh Ấn.
- Quái / thực thể Linh Giới.
- Cổng quay lại đấu trường.
- Dấu vết Thiên Khung Hội.
- Manh mối về An Nhiên.

## 10.2. Thử thách theo Linh Ấn

| Linh Ấn thất lạc | Thử thách                             |
| ---------------- | ------------------------------------- |
| Ấn Nhãn          | Mê cung ánh sáng, tầm nhìn hạn chế    |
| Ấn Thủ           | Điều khiển lực, thao tác chính xác    |
| Ấn Túc           | Địa hình hạn chế di chuyển            |
| Ấn Tâm           | Ảo ảnh thất bại, cảm xúc              |
| Ấn Trí           | Câu đố logic, chiến thuật             |
| Ấn Khí           | Kết nối dòng năng lượng               |
| Ấn Hồn           | Đối mặt phiên bản rỗng của chính mình |

## 10.3. Kết quả sau khi hoàn thành

- Linh Ấn được hồi phục.
- Cơ Hồn Thẻ mở lại quyền thi đấu.
- Người chơi quay về sảnh chính.
- Sao đã mất không được hoàn lại.

---

# 11. Ảnh Linh Đấu Thủ

## 11.1. Mục đích thiết kế

Vì game là offline single-player, người chơi không đấu online với người thật. Để vẫn giữ cảm giác thi đấu trong hệ thống rank lớn, người chơi đấu với **Ảnh Linh Đấu Thủ**.

## 11.2. Định nghĩa

Ảnh Linh Đấu Thủ là bản mô phỏng:

- Linh Xác.
- Kỹ thuật đánh.
- Phong cách chiến đấu.
- Dữ liệu Linh Lực.
- Hành vi của Cơ Hồn Sư khác.

## 11.3. Hai loại Ảnh Linh

1. **Ảnh Linh thường:** dùng cho trận rank thường, độ khó tăng dần.
2. **Ảnh Linh đặc biệt:** dựa trên nhân vật có cốt truyện như Bách, Yuna, Raven, Seraphina, Hạo Nhiên, Vệ Cơ Sứ.

Bí mật về sau:

- Một số Ảnh Linh không chỉ là mô phỏng.
- Chúng có thể chứa mảnh ký ức thật của Cơ Hồn Sư từng bị hệ thống nuốt mất.

---

# 12. Nhân vật

## 12.1. Dàn nhân vật lõi cần ưu tiên

1. An Nhiên — người quan trọng đã biến mất.
2. Lâm Vô Cơ — mentor.
3. Hạo Nhiên — rival.
4. Mika — bạn đồng hành.
5. Ông Ký Ức — NPC Đảo Lưu Đày.
6. Elias Vân — phản diện chính.

## 12.2. Nhân vật mở rộng

- Seraphina — idol Cơ Hồn Sư, tuyến danh vọng.
- Lyra — NPC cảm xúc ở Đảo Lưu Đày.
- Vệ Cơ Sứ — boss phụ theo chương.
- Bách, Yuna, Raven — đối thủ đại diện theo rank.

## 12.3. Lâm Vô Cơ

**Vai trò:** Mentor / người dẫn đường.

Đặc điểm:

- Cựu Cơ Hồn Sư từng leo rank cao.
- Chủ quán cơ nhỏ ở Tân Linh Đô.
- Hiểu mặt tối của Linh Cơ Đấu.
- Dạy luật cơ bản.
- Cho người chơi cây cơ đầu tiên.
- Cảnh báo đừng quá tin bảng xếp hạng.

Câu thoại:

> Cú đánh mạnh nhất không phải cú đánh khiến đối thủ thua. Mà là cú đánh khiến con không đánh mất chính mình.

## 12.4. Hạo Nhiên

**Vai trò:** Rival / đối thủ đầu game.

Đặc điểm:

- Trẻ, nổi tiếng, lạnh lùng.
- Đánh chính xác.
- Tập trung phong ấn Ấn Nhãn và Ấn Trí.
- Khiến người chơi lần đầu rơi xuống Đảo Lưu Đày.
- Về sau có thể thành đồng minh.

Câu thoại:

> Nếu chỉ một trận thua đã khiến cậu gục xuống, thì đừng leo cao hơn nữa.

## 12.5. Mika

**Vai trò:** Bạn đồng hành.

Đặc điểm:

- Vui vẻ, nói nhiều, mê skin và gậy cơ.
- Hiểu cộng đồng, tin đồn, sự kiện, idol.
- Hướng dẫn tính năng như skin, cửa hàng, nhiệm vụ.
- Tạo màu sắc đời thường.
- Có tuyến phụ: muốn nổi tiếng nhưng sợ đánh mất bản thân.

Câu thoại:

> Tớ không cần thành huyền thoại đâu… nhưng mà nếu có skin huyền thoại thì cũng được.

## 12.6. Seraphina

**Vai trò:** Idol Cơ Hồn Sư / biểu tượng danh vọng.

Đặc điểm:

- Nổi tiếng toàn cầu.
- Skin đẹp, hiệu ứng lộng lẫy, fan đông.
- Bị ràng buộc bởi hợp đồng Linh Ấn.
- Mỗi lần xuất hiện trước công chúng lại mất thêm quyền kiểm soát Linh Xác.
- Có thể trở thành boss cảm xúc ở chương quan trọng.

Câu thoại:

> Họ gọi tôi là ánh sáng của đấu trường. Nhưng ánh sáng này không còn thuộc về tôi nữa.

## 12.7. Ông Ký Ức

**Vai trò:** NPC Đảo Lưu Đày / người giữ bí mật.

Đặc điểm:

- Ghi chép tên Cơ Hồn Sư từng rơi xuống đảo.
- Biết luật thật của Linh Cơ Đấu.
- Giao nhiệm vụ tìm lại Linh Ấn.
- Cảnh báo về những người không thể quay về.

Câu thoại:

> Người ta không biến mất khi thua. Họ biến mất khi không còn nhớ mình là ai.

## 12.8. Lyra

**Vai trò:** NPC cảm xúc trên Đảo Lưu Đày.

Đặc điểm:

- Mắc kẹt do mất Ấn Túc.
- Không thể rời khỏi khu vực nhất định.
- Sau khi được giúp, có thể hỗ trợ dò Linh Ấn.
- Cho người chơi thấy hậu quả thật sự của thất bại.

Câu thoại:

> Em không sợ ở lại đây. Em chỉ sợ một ngày nào đó em quên mất mình từng muốn đi đâu.

## 12.9. Vệ Cơ Sứ

**Vai trò:** Đội chấp hành Thiên Khung Hội / boss phụ.

Các loại:

- Sứ Giả Nhãn: đọc đường đánh, dự đoán tương lai ngắn.
- Sứ Giả Thủ: lực đánh cực mạnh.
- Sứ Giả Tâm: gây nhiễu tinh thần, tạo ảo ảnh.
- Sứ Giả Hồn: canh giữ cổng Linh Giới.

---

# 13. Cốt truyện chính

## 13.1. Cấu trúc chương ngắn

1. Thành phố của những Cơ Hồn Sư.
2. Trận thua đầu tiên.
3. Đảo Lưu Đày.
4. Leo rank.
5. Bí mật Thiên Khung Hội.
6. Thần Cơ Tháp.

## 13.2. Cấu trúc hồi chi tiết

### Hồi 1: Thành phố của danh vọng

- Mở đầu tại Tân Linh Đô.
- Linh Cơ Đấu là hiện tượng toàn cầu.
- Người chơi giữ Linh Cầu nứt của An Nhiên.
- Đăng ký Linh Cơ Đấu.
- Tạo Linh Xác.
- Hệ thống phát hiện Linh Ấn Không Xác Định.
- Gặp Mika.
- Gặp Lâm Vô Cơ.

### Hồi 2: Trận thua đầu tiên

- Người chơi gặp Hạo Nhiên.
- Hạo Nhiên phong ấn Linh Ấn quan trọng.
- Người chơi thua.
- Lần đầu bị đưa đến Đảo Lưu Đày.

### Hồi 3: Đảo Lưu Đày

- Người chơi tỉnh dậy trên đảo.
- Gặp Ông Ký Ức.
- Tìm lại Linh Ấn.
- Gặp Lyra.
- Linh Cầu nứt của An Nhiên phản ứng.
- Người chơi hiểu Linh Cơ Đấu không còn là trò chơi bình thường.

### Hồi 4: Leo rank và mặt trái danh vọng

- Người chơi gặp nhiều đối thủ theo rank.
- Bách: muốn đổi đời.
- Yuna: áp lực thành tích.
- Raven: chợ đen Linh Ấn.
- Seraphina: danh vọng và hợp đồng Linh Ấn.
- Người chơi thấy nhiều người tham gia vì ước mơ thật, không chỉ vì tham vọng xấu.

### Hồi 5: Sự thật về Thiên Khung Hội

- Vệ Cơ Sứ xuất hiện.
- Dữ liệu Cơ Hồn Sư bị xóa.
- Lâm Vô Cơ tiết lộ đấu trường là mắt trận.
- Người chơi biết về Đại Sụp Linh và Thiên Khung Trận.
- Elias xuất hiện và trình bày lý tưởng.

### Hồi 6: Thần Cơ Tháp

- Người chơi vào đấu trường cao nhất.
- Bàn đấu là bản đồ thu nhỏ của Linh Giới.
- An Nhiên tồn tại trong tầng sâu Linh Giới.
- Elias muốn người chơi trở thành Chân Cơ Hồn.
- Người chơi phải chứng minh có cách cứu thế giới khác.

### Hồi 7: Kết thúc mở đề xuất

- Người chơi đánh bại Elias.
- Không phá hủy hoàn toàn Thiên Khung Trận.
- Tái cấu trúc hệ thống bằng năng lực cộng hưởng.
- Thiên Khung Trận không còn hút Linh Lực cưỡng ép.
- Đảo Lưu Đày trở thành vùng phục hồi.
- An Nhiên được giải phóng một phần.
- Elias thất bại nhưng để lại câu hỏi đạo đức.

Câu hỏi còn lại:

> Khi thảm họa thật sự đến, liệu lòng tự nguyện của con người có đủ nhanh để cứu họ không?

---

# 14. Đấu trường

## 14.1. Danh sách đấu trường

1. **Tân Cơ Đài** — sân tập đầu tiên, dành cho tân thủ.
2. **Đồng Thành Arena** — đấu trường thành phố công nghiệp.
3. **Ngân Hải Đài** — đấu trường trên biển.
4. **Kim Quang Palace** — đấu trường quý tộc, hào nhoáng.
5. **Huyền Thạch Dome** — đấu trường ngầm, bí ẩn.
6. **Tinh Vân Court** — đấu trường giữa trời, nhiều hiệu ứng ánh sáng.
7. **Thần Cơ Tháp** — đấu trường cấp cao, lõi bí mật của Thiên Khung Hội.

## 14.2. Vai trò thiết kế

- Mỗi đấu trường nên gắn với một rank.
- Mỗi đấu trường là một mắt trận của Thiên Khung Trận.
- Mỗi đấu trường có đối thủ, hiệu ứng và chủ đề riêng.
- Thần Cơ Tháp là điểm hội tụ cốt truyện.

---

# 15. Visual, skin, gậy cơ & hiệu ứng

## 15.1. Phong cách hình ảnh

- Anime fantasy 3D cao cấp.
- Đẹp, sáng, hiện đại, có chiều sâu.
- Nhân vật có thời trang fantasy hiện đại.
- Thành phố có công nghệ và ma thuật.
- Đấu trường có hologram và hiệu ứng năng lượng.
- Bàn bi-da giống pháp trận chiến đấu.
- Linh Cầu phát sáng như tinh thể.
- Gậy cơ giống ma pháp khí.

## 15.2. Skin nhân vật

Các cấp skin:

1. **Skin thường:** đơn giản, sạch, dễ nhìn.
2. **Skin hiếm:** có phụ kiện Linh Ấn, ánh sáng nhẹ.
3. **Skin sử thi:** có aura riêng, animation vào trận.
4. **Skin huyền thoại:** có cinematic intro, hiệu ứng đánh cơ riêng, âm thanh riêng.

Nguyên tắc:

- Skin không chỉ là đổi quần áo.
- Skin nên thể hiện cá tính, hệ Linh Lực và hành trình nhân vật.

## 15.3. Skin gậy cơ

Các loại gậy cơ:

- Cơ Gió: vệt gió xoáy.
- Cơ Lửa: tia lửa.
- Cơ Băng: vệt băng mờ.
- Cơ Lôi: tia điện.
- Cơ Nguyệt: xanh tím, bí ẩn.
- Cơ Hắc Tinh: hiệu ứng vũ trụ.

Nguyên tắc:

- Có thể có chỉ số nhẹ.
- Không nên pay-to-win.

## 15.4. Hệ thống kỹ năng

Các hệ đề xuất:

- Gió: linh hoạt, đổi hướng bi.
- Lửa: tăng lực, áp lực cao.
- Băng: kiểm soát bàn đấu.
- Lôi: combo nhanh.
- Ảo: đánh lừa đường ngắm.
- Quang: hồi phục Linh Ấn.
- Ảnh: phong ấn đối thủ.

Bản đầu chưa cần làm hết. Chỉ cần 1–2 kỹ năng cơ bản để kiểm tra gameplay.

---

# 16. Tiến hóa Linh Xác

## 16.1. Giai đoạn tiến hóa

1. **Linh Xác Thô**  
   Trang phục đơn giản, ít hiệu ứng, gậy cơ cơ bản.

2. **Linh Xác Thức Tỉnh**  
   Sau lần đầu thoát khỏi Đảo Lưu Đày, trang phục xuất hiện hoa văn Linh Ấn.

3. **Linh Xác Phân Nhánh**  
   Người chơi chọn hệ phát triển: Gió, Lửa, Băng, Lôi, Ảo, Quang, Ảnh.

4. **Chân Linh Xác**  
   Người chơi không còn chạy theo hình dạng hệ thống tạo ra, mà tự định hình bản thân.

5. **Chân Cơ Hồn**  
   Trạng thái cao nhất, liên quan trực tiếp đến Thiên Khung Trận và lựa chọn cuối game.

## 16.2. Ý nghĩa

> Ban đầu người chơi chọn một cái xác để được công nhận. Cuối cùng người chơi tự tạo ra hình dạng thật của chính mình.

---

# 17. Nền móng dự án chính

## 17.1. Định hướng đã chốt

Phần này thay thế tư duy **MVP thử**.

Dự án không triển khai theo hướng tạo bản demo rời rạc rồi bỏ đi. Ngay từ lần tạo Unity project đầu tiên, đây được xem là **project chính thức**.

Câu chốt:

```text
Không làm bản thử rời rạc.
Làm project chính thức từ đầu.
Mỗi giai đoạn chỉ mở một phần nhỏ, nhưng code phải sạch và dùng lâu dài.
```

## 17.2. Nguyên tắc triển khai

1. Không tạo project thử để bỏ.
2. Không code nhanh cho có rồi sửa toàn bộ sau.
3. Không nhét mọi logic vào một script lớn.
4. Không làm gameplay trước khi thiếu cấu trúc thư mục, scene, hệ thống quản lý.
5. Mỗi phần code phải nằm trong kiến trúc chính.
6. Ưu tiên code sạch, dễ đọc, dễ mở rộng.
7. Tách rõ dữ liệu, gameplay, UI, scene, visual/audio và debug tools.

## 17.3. Cấu trúc thư mục đề xuất

```text
Assets/
├── _Project/
│   ├── Art/
│   ├── Audio/
│   ├── Data/
│   ├── Materials/
│   ├── Prefabs/
│   ├── Scenes/
│   ├── Scripts/
│   ├── ScriptableObjects/
│   ├── UI/
│   └── VFX/
```

## 17.4. Scene định hướng

- Boot / Init.
- Main Menu.
- Tân Cơ Đài.
- Đảo Lưu Đày.
- UI Test Scene.

## 17.5. Hệ thống nền cần có

### Core gameplay bi-da

- Bàn đấu.
- Bi trắng.
- Linh Cầu.
- Lỗ bàn.
- Hướng ngắm.
- Kéo lực đánh.
- Va chạm vật lý.
- Kiểm tra bi rơi lỗ.
- Kết thúc lượt.

### Hệ thống Linh Ấn

- Tên Linh Ấn.
- Biểu tượng.
- Màu hiệu ứng.
- Trạng thái ổn định / bị phong ấn / thất lạc / hồi phục.
- Ảnh hưởng gameplay.
- Liên kết với Linh Cầu tương ứng.

### Hệ thống trận đấu

- Bắt đầu trận.
- Lượt đánh.
- Linh Cầu còn lại.
- Linh Ấn đã bị phong ấn.
- Điều kiện thắng.
- Điều kiện thua.
- Kết quả trận.
- Chuyển màn thưởng hoặc Đảo Lưu Đày.

### UI / HUD

- Trạng thái Linh Ấn.
- Thanh lực đánh.
- Hướng ngắm.
- Cơ Hồn Thẻ cơ bản.
- Rank sao.
- Thông báo phong ấn.
- Kết quả trận.

### Data config

- Danh sách Linh Ấn.
- Danh sách rank.
- Luật cộng / trừ sao.
- Thông tin đấu trường.
- Thông tin đối thủ.
- Thông tin gậy cơ.

### Save / Load

- Tên người chơi.
- Rank hiện tại.
- Số sao hiện tại.
- Trạng thái Linh Ấn.
- Cơ Hồn Thẻ.
- Tiến trình cốt truyện.

### Debug tools

- Reset rank.
- Cộng sao.
- Trừ sao.
- Phong ấn Linh Ấn.
- Hồi phục Linh Ấn.
- Chuyển scene nhanh.
- Test thắng / thua.

## 17.6. Lát cắt chính thức đầu tiên

Đây là một phần nhỏ của game nhưng nằm trong project chính thức, dùng kiến trúc chính thức và có thể mở rộng.

Bao gồm:

- Scene Tân Cơ Đài.
- 1 bàn Linh Cơ Đấu.
- 1 nhân vật người chơi.
- 1 đối thủ NPC hoặc Ảnh Linh Đấu Thủ cơ bản.
- 7 Linh Cầu đại diện 7 Linh Ấn.
- Cơ chế đánh bi.
- Cơ chế phong ấn Linh Ấn.
- Điều kiện thắng / thua.
- UI Linh Ấn.
- Cơ Hồn Thẻ cơ bản.
- Rank sao cơ bản.
- Kết quả trận đấu.
- Chuyển scene sau khi thua.

Chưa làm ngay:

- Thế giới mở.
- Nhiều đấu trường.
- Nhiều nhân vật phụ.
- Skin phức tạp.
- Gacha.
- Online multiplayer.
- Đảo Lưu Đày lớn.
- Cinematic dài.

## 17.7. Lộ trình theo lớp

1. Giai đoạn 1: Xây nền project chính.
2. Giai đoạn 2: Làm core gameplay bi-da.
3. Giai đoạn 3: Gắn Linh Ấn vào gameplay.
4. Giai đoạn 4: Làm trận đấu hoàn chỉnh.
5. Giai đoạn 5: Làm progression / rank / sao.
6. Giai đoạn 6: Làm cốt truyện / scene / UI.
7. Giai đoạn 7: Làm visual polish.

---

# 18. Workflow agent khi bắt đầu code

Workflow đã chốt:

- **Codex:** agent code chính.
- **RooCode:** kiểm tra an toàn, Git, Gitleaks, commit/push.
- **ChatGPT:** mentor/PM kỹ thuật, xem repo GitHub public.

Nguyên tắc:

- RooCode không tự sửa logic code nếu chưa được yêu cầu.
- Sau mỗi lần Codex code xong, RooCode quét Gitleaks trước khi commit.
- Không push GitHub nếu có secret.
- Không lộ token/API key/password/private key.
- ChatGPT review qua repo GitHub public sau khi push.

---

# 19. Những điều đã chốt

1. Game làm trên Unity.
2. Game là 3D.
3. Phong cách anime fantasy hiện đại.
4. Chủ đề chính là bi-da ma thuật.
5. Người chơi là Cơ Hồn Sư.
6. Trò chơi trong thế giới game là Linh Cơ Đấu.
7. Tổ chức bí ẩn là Thiên Khung Hội.
8. Người chơi chọn nhân vật qua Linh Xác.
9. Nhân vật chính có Linh Ấn Không Xác Định.
10. Linh Cầu rơi vào lỗ sẽ phong ấn Linh Ấn.
11. Thắng thì hồi phục Linh Ấn và leo rank.
12. Thua thì vào Đảo Lưu Đày.
13. Thua không game over.
14. Game là offline single-player.
15. Rank dùng hệ thống 5 sao.
16. Thắng trận thường +1 sao.
17. Đủ 5 sao mở Trận Thăng Rank.
18. Thua nếu có sao thì -1 sao.
19. Thua ở 0 sao không bị trừ sao, nhưng vẫn vào Đảo Lưu Đày.
20. Cơ Hồn Thẻ là menu gameplay và công cụ kể chuyện.
21. Không làm MVP thử rời rạc.
22. Unity project đầu tiên là project chính thức.
23. Nhánh triển khai đổi thành Nền móng dự án chính.
24. Lát cắt đầu tiên phải dùng tiếp lâu dài.

---

# 20. Những phần cần chốt tiếp

1. Tên game chính thức.
2. Tên thế giới.
3. Tên thành phố chính có giữ Tân Linh Đô không.
4. Quan hệ chính thức giữa người chơi và An Nhiên.
5. Luật bi-da cụ thể.
6. Điều kiện thắng / thua chi tiết trong trận.
7. AI của Ảnh Linh Đấu Thủ.
8. Chỉ số và tác động cụ thể từng Linh Ấn.
9. Thiết kế Đảo Lưu Đày bản đầu.
10. Thiết kế Cơ Hồn Thẻ UI.
11. Thiết kế Tân Cơ Đài.
12. Thiết kế nhân vật chính và An Nhiên.
13. Phạm vi lát cắt chính thức đầu tiên.
14. Thứ tự giao việc cho Codex/RooCode.
15. Chuẩn repo GitHub và Gitleaks.
