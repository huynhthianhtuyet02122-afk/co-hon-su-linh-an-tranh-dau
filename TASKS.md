# TASKS

## Trạng thái hiện tại

- Đã tạo và gắn bộ skill nền tảng.
- Đã hoàn tất tạo/gắn 3 skill: clean-architecture-custom, game-design-custom, qa-testing-custom.
- Đã đổi workflow từ RooCode sang CoHonSu Safety Git.
- Unity project chính thức đã tạo tại root repo.
- Official Unity Foundation v0.1 đã push ở commit `3eba809`.
- Chưa code gameplay.

## Đang làm

- Cập nhật tài liệu trạng thái sau khi foundation v0.1 đã push.
- Chuẩn bị kiểm tra kiến trúc foundation.
- Chuẩn bị task gameplay slice đầu tiên.

## Bước tiếp theo

1. Giao CoHonSu Technical Architect kiểm tra kiến trúc foundation v0.1.
2. Chốt gameplay slice đầu tiên đủ nhỏ để triển khai.
3. Tạo task riêng cho Unity Builder sau khi scope slice được chốt.
4. Sau mỗi thay đổi quan trọng, Safety Git kiểm tra Git/Gitleaks trước commit/push.

## Backlog gần

1. Kiểm tra kiến trúc foundation v0.1.
2. Tạo scene bootstrap placeholder nếu cần.
3. Tạo sample ScriptableObject config nếu cần.
4. Chốt gameplay slice đầu tiên.
5. Sau đó mới bắt đầu core gameplay bi-da ở phạm vi nhỏ.

## Rủi ro

- Mở rộng foundation thành gameplay thật khi chưa chốt slice.
- Unity Builder commit/push nhầm thay vì chuyển cho CoHonSu Safety Git.
- Concept dài bị nhét vào file điều hướng làm agent tốn token.
- Gitleaks chưa được chạy trước commit/push.
