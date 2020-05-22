import java.util.ArrayList;
import java.util.Objects;

public class WorkPhysMemory {
	private int sizeConstant;
	private int sizeSector;
	private int sizePaintSquares;
	private Cell[] place;
	private Cell startSelectedFile;
	private Cell endCell = new Cell(-1);
	private ArrayList<CellTable> tableOfFileSystem = new ArrayList<CellTable>();
	
	public WorkPhysMemory(int sizeDisc,int sizeSector) {
		
		this.sizeConstant = sizeDisc;
		this.sizeSector = sizeSector;
		this.sizePaintSquares = (int) Math.sqrt(Double.parseDouble(sizeDisc/sizeSector+""));
		place = new Cell[sizeDisc/sizeSector];
		for (int i = 0; i < place.length; i++) {
			place[i] = new Cell(sizeSector);
		}
	}
	

	public void allocateMemoryForFile(File file) {
		tableOfFileSystem.add(new CellTable(file,file.getStartInMem()));
		int size = file.getSize();
		int countSectors=size/sizeSector;
		Cell prevSector = null;
		if(size%sizeSector>0)
			countSectors++;
		for (int i = 0; i < place.length; i++) {
			if(place[i].getCell()==null && file.getStartInMem() == null) {
				place[i].setCell(endCell);
				place[i].setStatus(1);
				prevSector = place[i];	
				countSectors--;
				file.setStartInMem(place[i]);
			} else if (place[i].getCell() == null) {
				place[i].setCell(endCell);
				place[i].setStatus(1);
				prevSector.setCell(place[i]);
				prevSector = place[i];				
				countSectors--;
			}
			if (countSectors==0)
				break;
		}	
	}
	
	public void clearMemory(File file) {
		for (int i = 0; i < place.length; i++) {
			if(place[i].getStatus()==2) {
				place[i] = new Cell(sizeSector);
			}
		}
		if(file.getFolder()) {
			clearFolder(file.getChilds());
		}
	}

	private void clearFolder(ArrayList<File> childs) {
		for (File file : childs) {
			if(file.getFolder()) {
				clearFolder(file.getChilds());
			}
			clearFile(file.getStartInMem());
		}
	}


	private void clearFile(Cell cell) {
		if(cell!=endCell) {
			clearFile(cell.getCell());
		}
		cell.setStatus(0);
	}


	public void setStartSelectedFile(Cell startSelectedFile) {
		this.startSelectedFile = startSelectedFile;
		clearStatus();
		setStatusSelect(startSelectedFile);
	}


	private void setStatusSelect(Cell cell) {
		
		if(cell.getCell().GetSize()!=-1) {
			setStatusSelect(cell.getCell());		
		}	
		cell.setStatus(2);	
	}


	private void clearStatus() {
		for (int i = 0; i < place.length; i++) {
			if(place[i].getStatus()==2) {
				place[i].setStatus(1);
			}
		}
		
	}


	public int getSizeDisc() {
		return sizeConstant;
	}


	public void setSizeDisc(int sizeDisc) {
		this.sizeConstant = sizeDisc;
	}


	public int getSizeSector() {
		return sizeSector;
	}


	public void setSizeSector(int sizeSector) {
		this.sizeSector = sizeSector;
	}


	public int getSizePaintSectors() {
		return sizePaintSquares;
	}


	public void setSizePaintSectors(int sizePaintSectors) {
		this.sizePaintSquares = sizePaintSectors;
	}


	public Cell[] getPlace() {
		return place;
	}


	public void setPlace(Cell[] place) {
		this.place = place;
	}


	public ArrayList<CellTable> getTables() {
		return tableOfFileSystem;
	}


	public void setTables(ArrayList<CellTable> tables) {
		this.tableOfFileSystem = tables;
	}
	
	public Cell getCell(int i) {
		return place[i];
	}

}
