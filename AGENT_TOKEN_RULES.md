# Agent Token & Output Rules

## Mục tiêu

Tối ưu token khi làm dự án dài hạn Cơ Hồn Sư bằng cách giảm input không cần thiết và giới hạn output quá dài.
Từ bây giờ, để tiết kiệm token:

- Không dùng lệnh lấy toàn bộ comment history nếu không cần.
- Không đọc full issue comment list dạng JSON nếu task chỉ cần trạng thái mới nhất.
- Ưu tiên đọc AGENTS.md, TASKS.md, DEV_LOG.md.
- Chỉ đọc comment gần nhất hoặc handoff summary gần nhất nếu cần.
- Không mở concept dài hoặc miro outline dài nếu task không liên quan trực tiếp.
- Mỗi issue chỉ làm một việc cụ thể.
- Output ngắn gọn, không lặp lại toàn bộ nội dung file.

## Input rules

- Luôn đọc AGENTS.md trước khi làm task.
- Chỉ đọc thêm file được task yêu cầu.
- Không đọc docs/concept_co_hon_su_v4_chuyen_nghiep.md nếu task không cần chi tiết game design.
- Không đọc docs/miro_board_outline.md nếu task không liên quan Miro/game design board.
- Ưu tiên đọc file ngắn ở root trước:
  - README.md
  - TASKS.md
  - ARCHITECTURE.md
  - GAME_DESIGN_SUMMARY.md
  - SECURITY.md
  - TOOLS_AND_PIPELINE.md
- Chỉ mở concept dài khi task cần chi tiết về lore, nhân vật, Linh Ấn, rank, Đảo Lưu Đày hoặc cốt truyện.

## Output rules

- Trả lời ngắn gọn, có cấu trúc.
- Không in toàn bộ nội dung file nếu người dùng không yêu cầu.
- Không in full diff nếu người dùng không yêu cầu.
- Không in log dài; chỉ tóm tắt lỗi quan trọng.
- Không lặp lại nội dung concept dài.
- Không in secret/token/password/private key.
- Sau khi làm xong, chỉ báo:
  1. File đã tạo/sửa
  2. Tóm tắt thay đổi
  3. Lệnh đã chạy
  4. Kết quả kiểm tra
  5. Vấn đề cần người dùng xác nhận nếu có

## Task sizing rules

- Chia task lớn thành task nhỏ.
- Mỗi task chỉ nên có một mục tiêu chính.
- Không vừa refactor, vừa thêm feature, vừa sửa Git trong cùng một task.
- Không để Codex vừa design, vừa code, vừa commit/push.
- CoHonSu Safety Git chỉ xử lý Git/Gitleaks/commit/push an toàn, không sửa logic code nếu chưa được yêu cầu.

## Tool usage rules

- Multica dùng để quản lý task/status khi dự án bắt đầu có nhiều task nhỏ.
- GitNexus dùng khi repo đã có code và cần hiểu file/class liên quan trước khi sửa/refactor/debug.
- Gitleaks dùng trước commit/push.
- GitHub public dùng để ChatGPT review repo sau khi push.

## Câu nhắc mẫu cho Codex

Trước khi code, hãy đọc AGENTS.md trước. Chỉ đọc thêm các file được task yêu cầu. Không đọc toàn bộ concept dài nếu task này không cần. Trả lời ngắn gọn, không in full file/full diff/full log.
