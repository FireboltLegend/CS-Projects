-- Code your testbench here
library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.STD_LOGIC_TEXTIO.ALL;
use STD.TEXTIO.all;

entity testTraffic is
end testTraffic;

architecture testArch of testTraffic is
    component traffic
        port(Ta, Tb : in STD_LOGIC;
             La, Lb : out STD_LOGIC_VECTOR(1 downto 0));
    end component;
    signal clk, reset, Ta, Tb : STD_LOGIC;
    signal La, Lb : STD_LOGIC_VECTOR(1 downto 0);
    type statetype is (S0, S1, S2, S3);
    signal state, nextState: statetype;
begin
    dut : traffic port map(Ta, Tb, La, Lb);
    process begin
        clk <= '1'; wait for 5ns;
        clk <= '0'; wait for 5ns;
    end process;
    process begin
    	reset <= '1'; wait for 300 ns; reset <= '0';
        wait;
    end process;
    process is
      file tv : text;
      variable L : line;
      variable vector_in : std_logic_vector(1 downto 0);
      variable dummy : character;
      variable vector_out : std_logic_vector(3 downto 0);
      variable vectornum : integer := 0;
      variable errors : integer := 0;
    begin
    	FILE_OPEN(tv, "example.tv", READ_MODE);
        while not endfile(tv) loop
        	readline(tv, L);
          	read(L, vector_in);
            read(L, dummy);
            read(L, vector_out);
            Ta <= vector_in(0);
            Tb <= vector_in(1);
            
            if rising_edge(clk) then
                if vector_out /= La then
                    report "Error: La = " &
                    to_string(La) &
                    " expected = " &
                    to_string(vector_out);
                    errors := errors + 1;
                end if;
                if vector_out /= Lb then
                    report "Error: Lb = " &
                    to_string(Lb) &
                    " expected = " &
                    to_string(vector_out);
                    errors := errors + 1;
                end if;
                vectornum := vectornum + 1;
            end if;
        end loop;
        if (errors = 0) then
        	report "NO ERRORS -- " &
            integer'image(vectornum) &
            " tests completed successfully."
            severity failure;
        else
        	report integer'image(vectornum) &
            " tests completed, errors = " &
            integer'image(errors)
            severity failure;
        end if;
        wait;
    end process;
end testArch;