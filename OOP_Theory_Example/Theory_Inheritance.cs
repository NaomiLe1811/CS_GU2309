1/ TH1: lớp con ko có hàm -> sài hàm lớp cha
2/ TH2: lớp con có hàm riêng dùng tên hàm lớp cha => ưu tiên gọi hàm lớp con (nhưng sẽ bị warning)
3/ TH3: lớp con muốn ghi đè (định nghĩa lại hàm của lớp cha) -> virtual (lớp cha) -> override (lớp con) -> mất warning
4/ TH4: Lớp con tái sử dụng lớp cha -> base