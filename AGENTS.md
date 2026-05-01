# AGENTS

## Đọc đầu tiên

1. PROJECT_MEMORY.md
2. TASKS.md
3. DEV_LOG.md

AGENTS.md chỉ là bản đồ chỉ đường ngắn cho agent. Không nhét concept, log dài hoặc issue history vào file này.

## Project root bắt buộc

- Làm việc trong: `D:\Dự án game cơ hồn sư\CoHonSu_Project`
- Không làm việc trong `C:\Users\User\multica_workspaces..` trừ khi task yêu cầu rõ.
- Dùng cmd trên Windows cho project commands khi phù hợp.

## Vai trò chính

- CoHonSu Project Manager: điều phối task/issue/checklist/handoff; không code, không stage, không commit, không push.
- CoHonSu Unity Builder: code Unity khi được giao task rõ; không commit/push.
- CoHonSu Safety Git: xử lý Git, Gitleaks, commit/push; phải hỏi xác nhận trước commit và trước push.
- Safety Git agent ID: `50d8dabe-3f2a-4c4e-a006-24f73757cfaa`

## Luật token

- Mỗi issue chỉ đọc current issue/latest trigger comment nếu không được yêu cầu khác.
- Không đọc full issue/comment history.
- Không mở concept dài, miro dài hoặc docs dài nếu task không liên quan trực tiếp.
- Tránh `multica agent list --output json` nếu đã biết agent ID.
- Output ngắn: file đã đổi, nội dung chính, rủi ro, bước tiếp theo.

## Guardrails

- Không code nếu không đúng vai trò hoặc task không yêu cầu.
- Không commit/push nếu không phải Safety Git.
- Không tạo Unity project nếu task chưa yêu cầu.
- Không sửa concept gốc nếu task không liên quan game design.
- Không in token/API key/password/private key.
- Nếu phát hiện secret hoặc tiếng Việt lỗi encoding, dừng và báo lại.

## File tham chiếu khi cần

- `AGENT_TOKEN_RULES.md`: quy tắc tiết kiệm token.
- `AGENT_TEAM.md`: danh sách vai trò agent.
- `ARCHITECTURE.md`: kiến trúc Unity/code.
- `SECURITY.md`: Git, Gitleaks, secret safety.
- `GAME_DESIGN_SUMMARY.md`: design/lore/rank/gameplay scope.
- `docs/concept_co_hon_su_v4_chuyen_nghiep.md`: concept dài, chỉ mở khi thật sự cần.
