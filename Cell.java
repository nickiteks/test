
public class Cell {

	private int size;	
	private int status=0;
	// 0 - ������� 1 - ������ 2 - ��������
	
	public Cell(int size) {
		this.size = size;
	}
	public void SetSize(int size) {
		this.size =size;
	}
	public int GetSize() {
		return size;
	}
	public int getStatus() {
		return status;
	}
	public void setStatus(int status) {
		this.status = status;
	}
}
