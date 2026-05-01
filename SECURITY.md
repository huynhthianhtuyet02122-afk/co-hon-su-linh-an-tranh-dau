# SECURITY

## Nguyên tắc an toàn

- Không lưu token/API key/password/private key trong repo.
- Không in token/API key/password/private key ra log, comment, issue hoặc báo cáo.
- Dùng `.gitignore` để chặn file nhạy cảm, cache, build output và file local.
- Nếu phát hiện secret thì dừng, không commit, không push.

## Agent phụ trách

CoHonSu Safety Git là agent duy nhất phụ trách Git safety, Gitleaks, commit và push.

Phạm vi của CoHonSu Safety Git:

- Chạy `git status`.
- Kiểm tra git remote/branch.
- Chạy Gitleaks full scan.
- Chạy Gitleaks staged scan.
- Kiểm tra file nhạy cảm trước commit.
- Hỏi xác nhận người dùng trước commit.
- Hỏi xác nhận người dùng trước push.

## Luật commit/push

- CoHonSu Project Manager không commit/push.
- CoHonSu Unity Builder không commit/push.
- CoHonSu Safety Git không commit/push nếu chưa có xác nhận rõ ràng.
- Nếu Gitleaks hoặc kiểm tra file nhạy cảm phát hiện rủi ro, dừng workflow Git và báo lại.
