package subd.repository;

import org.springframework.data.jpa.repository.Query;
import subd.entity.Werehouse;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.sql.Timestamp;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;

@Repository
public interface WerehouseRepository extends JpaRepository<Werehouse, Integer> {
    @Query("SELECT w FROM Werehouse w WHERE w.date <= current_date and w.date >= :date " )
    public List<Werehouse> getAllByDateBetween(Date date);
}
