# Cơ Hồn Sư: Linh Ấn Tranh Đấu

Đây là dự án game Unity 3D offline single-player cho **Cơ Hồn Sư: Linh Ấn Tranh Đấu**.

## Trạng thái hiện tại

- Pre-Unity project / documentation foundation.
- Đang chuẩn hóa tài liệu nền trước khi tạo Unity project chính thức.
- Chưa tạo Unity project.
- Chưa code gameplay.

## Cách đọc tài liệu

1. AGENTS.md: workflow agent và luật vận hành.
2. TASKS.md: trạng thái hiện tại, việc đang làm và bước tiếp theo.
3. DEV_LOG.md: mốc tiến độ ngắn.
4. GAME_DESIGN_SUMMARY.md: tóm tắt game design đã chốt.
5. ARCHITECTURE.md: định hướng Official Unity Foundation v0.1.
6. SECURITY.md: Git, Gitleaks và secret safety.
7. AGENT_TEAM.md: vai trò 7 agent hiện tại.

Concept dài nằm trong `docs/` và chỉ nên đọc khi task liên quan game design chi tiết.

## Workflow agent ngắn gọn

- ChatGPT: mentor/PM tổng ở ngoài Multica, review hướng đi và repo GitHub public.
- CoHonSu Project Manager: quản lý task, issue, tiến độ và handoff summary.
- CoHonSu Unity Builder: agent code chính khi bắt đầu Unity/Codex task; không commit/push.
- CoHonSu Game Designer: giữ game design không lệch.
- CoHonSu Technical Architect: giữ kiến trúc sạch.
- CoHonSu QA Tester: kiểm tra build, logic, scene và flow.
- CoHonSu Debug Doctor: xử lý lỗi cụ thể.
- CoHonSu Safety Git: agent duy nhất phụ trách Git, Gitleaks, commit và push an toàn.

## Guardrails

- Không tạo Unity project nếu task chưa yêu cầu.
- Không code gameplay nếu task chưa yêu cầu.
- Không commit/push ngoài CoHonSu Safety Git.
- Không nhét concept dài vào README.md hoặc AGENTS.md.
