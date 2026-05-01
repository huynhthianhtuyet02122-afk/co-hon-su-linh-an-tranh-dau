# AGENTS

## Đọc trước
- Project root: `D:\Dự án game cơ hồn sư\CoHonSu_Project`
- Đọc đầu tiên: `PROJECT_MEMORY.md`.
- Chỉ đọc thêm file khi task cần.

## File khi cần
- `CURRENT_STATE.md`: trạng thái ngắn nếu có.
- `TASKS.md`: trạng thái task.
- `DEV_LOG.md`: lịch sử gần nhất.
- `GAME_DESIGN_SUMMARY.md`: design/lore/gameplay.
- `ARCHITECTURE.md`: kiến trúc/code structure.
- `SECURITY.md`: Git/Gitleaks/secret.
- `docs/concept_co_hon_su_v4_chuyen_nghiep.md`: chỉ khi cần lore/design sâu.

## Vai trò
- CoHonSu Project Manager: điều phối task; không code, không stage/commit/push.
- CoHonSu Unity Builder/Codex: code Unity; không commit/push.
- CoHonSu Safety Git: duy nhất xử lý Git/Gitleaks/stage/commit/push; hỏi user trước commit và trước push.

## Luật token
- Focus current issue/latest trigger comment only.
- Không đọc full issue/comment history nếu user không yêu cầu.
- Không dùng full JSON output nếu không bắt buộc.
- Không in full diff/log/file dài ra comment.
- Output tối đa 20 dòng nếu không được yêu cầu chi tiết.

## Luật an toàn
- Không in token/API key/password/private key; nếu phát hiện secret, dừng và báo Safety Git; nếu tiếng Việt lỗi encoding, dừng và báo `Encoding error`.
