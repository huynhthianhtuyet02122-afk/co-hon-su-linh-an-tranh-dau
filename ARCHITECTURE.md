# ARCHITECTURE

## Định hướng

Official Unity Foundation v0.1 là nền tảng chính thức của dự án, không phải MVP bỏ đi.

Hiện tại dự án vẫn ở giai đoạn pre-Unity project / documentation foundation:

- Chưa tạo Unity project chính thức.
- Chưa code gameplay.
- Chưa triển khai scene, script, prefab hoặc asset runtime.

## Phạm vi v0.1

- Official Unity Foundation v0.1 chỉ tập trung vào hạ tầng kỹ thuật và placeholder cần thiết.
- Chưa triển khai gameplay bi-da phức tạp.
- Chưa triển khai luật đấu hoàn chỉnh.
- Chưa triển khai AI đối thủ hoàn chỉnh.
- Chưa triển khai combat/gameplay loop đầy đủ.
- Mục tiêu là tạo nền móng sạch để các hệ thống sau này mở rộng.

## Cấu trúc Unity dự kiến

- `Assets/_Project/Art`
- `Assets/_Project/Audio`
- `Assets/_Project/Data`
- `Assets/_Project/Materials`
- `Assets/_Project/Prefabs`
- `Assets/_Project/Scenes`
- `Assets/_Project/Scripts`
- `Assets/_Project/ScriptableObjects`
- `Assets/_Project/UI`
- `Assets/_Project/VFX`

## Scene dự kiến

- Boot/Init
- Main Menu
- Tân Cơ Đài
- Exile Island Placeholder
- UI Test Scene

## Hệ thống nền dự kiến

- Scene flow
- Game state
- Player profile
- Rank/star data
- Soul seal state
- Save/load
- Debug panel
- Sample data
- UI placeholder

## Nguyên tắc kỹ thuật

- Giữ foundation nhỏ, rõ boundary, dễ test.
- Không framework hóa sớm.
- Không đưa gameplay hoàn chỉnh vào foundation v0.1 nếu chưa có task riêng.
