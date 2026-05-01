# TOOLS AND PIPELINE

## Pipeline công cụ

- Unity = game engine chính.
- VS Code = nơi theo dõi thay đổi file trong repo khi Codex/Unity Builder sửa trực tiếp.
- CoHonSu Unity Builder / Codex = agent code chính khi có task triển khai rõ.
- CoHonSu Safety Git = Git, Gitleaks, kiểm tra an toàn, commit/push khi được xác nhận.
- GitNexus = hỗ trợ hiểu codebase khi repo bắt đầu có nhiều code.
- Multica = quản lý task/status/handoff nếu setup ổn.
- Blender = chỉnh asset 3D khi cần.
- Tripo AI = tạo model 3D nháp từ text/image, cần kiểm tra lại trước khi đưa vào Unity.
- GitHub = lưu repo public để ChatGPT review.
- Gitleaks = quét secret trước commit/push.

## Nguyên tắc

- Unity trước, Blender sau.
- Code nền trước, asset đẹp sau.
- Asset AI không đưa thẳng vào game nếu chưa kiểm tra scale, poly, material, license.
- Mỗi task mới nên đọc AGENTS.md, TASKS.md và DEV_LOG.md trước.
- CoHonSu Unity Builder không tự commit/push.
- CoHonSu Safety Git hỏi xác nhận trước commit/push.
- Không tự tạo Unity project nếu task chưa yêu cầu.
