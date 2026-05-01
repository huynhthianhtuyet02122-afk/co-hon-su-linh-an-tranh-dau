# PROJECT MEMORY

- Project: Cơ Hồn Sư: Linh Ấn Tranh Đấu.
- Project root: D:\Dự án game cơ hồn sư\CoHonSu_Project
- Không làm việc trong C:\Users\User\multica_workspaces.. trừ khi được yêu cầu.
- File này là bộ nhớ ngắn nên đọc đầu tiên để giảm token input.
- Sau đó ưu tiên đọc TASKS.md và DEV_LOG.md.
- Chỉ đọc AGENTS.md khi cần luật điều phối chi tiết hơn.

## Workflow hiện tại

- Project Manager điều phối issue, checklist, handoff và phân task.
- Unity Builder code Unity khi được giao task rõ.
- Safety Git xử lý Git, Gitleaks, commit và push.
- Safety Git agent ID: 50d8dabe-3f2a-4c4e-a006-24f73757cfaa
- Project Manager không code, không stage, không commit, không push.
- Unity Builder không commit/push.
- Safety Git phải hỏi xác nhận trước commit và trước push.

## Token rules

- Mỗi issue chỉ đọc current issue/latest trigger comment.
- Không đọc full issue/comment history nếu không được yêu cầu.
- Không mở concept dài hoặc miro dài nếu task không liên quan.
- Tránh `multica agent list --output json` nếu đã biết agent ID.
- Output ngắn, tập trung vào file đã đổi, rủi ro và bước tiếp theo.

## Windows/project commands

- Dùng cmd trên Windows cho project commands khi phù hợp.
- Nếu tiếng Việt lỗi encoding, dừng và báo "Encoding error".
- Không dùng PowerShell stdin để pipe nội dung tiếng Việt có dấu vào Multica nếu chưa đảm bảo UTF-8.

## Trạng thái nền

- Đang ở giai đoạn documentation foundation / pre-Unity.
- Chưa tạo Unity project chính thức.
- Chưa code gameplay.
